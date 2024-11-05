using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Models.Dtos.Users;

namespace TodoProject.Service.Abstracts;

public interface IRoleService
{


    Task<string> AddRoleToUser(RoleAddToUserRequestDto dto);

    Task<List<string>> GetAllRolesByUserId(string userId);

    Task<string> AddRoleAsync(string name);
}