﻿using Core.Exceptions;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Models.Dtos.Users;
using TodoProject.Models.Entities;
using TodoProject.Service.Abstracts;

namespace TodoProject.Service.Concretes;

public sealed class RoleService : IRoleService
{
    private readonly UserManager<User> userManager;
    private readonly RoleManager<IdentityRole> roleManager;
    public RoleService(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
    {
        this.roleManager = roleManager;
        this.userManager = userManager;
    }
    public async Task<string> AddRoleToUser(RoleAddToUserRequestDto dto)
    {
        //Rol kontrolü
        var role = await roleManager.FindByNameAsync(dto.RoleName);
        RoleCheck(role);

        var user = await userManager.FindByIdAsync(dto.UserId);
        UserCheck(user);

        var addRoleToUser = await userManager.AddToRoleAsync(user, dto.RoleName);
        if (!addRoleToUser.Succeeded)
        {
            throw new BusinessException(addRoleToUser.Errors.First().Description);
        }

        return "Kulllanıcıya rol eklendi : " + dto.RoleName;
    }


    public async Task<List<string>> GetAllRolesByUserId(string userId)
    {
        var user = await userManager.FindByIdAsync(userId);

        var roles = await userManager.GetRolesAsync(user);


        return roles.ToList();
    }

    public async Task<string> AddRoleAsync(string name)
    {

        var role = new IdentityRole { Name = name };
        var checkRoleName = await roleManager.FindByNameAsync(name);
        if (checkRoleName is not null)
            throw new BusinessException("Eklemek istediğiniz rol benzerseiz olmalıdır.");


        var result = await roleManager.CreateAsync(role);
        if (!result.Succeeded)
            throw new BusinessException(result.Errors.First().Description);


        return "Rol eklendi" + name;
    }

    private void UserCheck(User? user)
    {
        if (user is null)
        {
            throw new NotFoundException("Kulllanıcı bulunamadı.");
        }
    }

    private void RoleCheck(IdentityRole? role)
    {
        if (role is null)
        {
            throw new BusinessException("rol bulunamadı.");
        }
    }


}
