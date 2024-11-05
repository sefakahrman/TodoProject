﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoProject.Models.Dtos.Users;
using TodoProject.Service.Abstracts;

namespace TodoProject.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController(IUserService _userService, IAuthenticationService _authenticationService) : ControllerBase
{


    [HttpPost("creeate")]
    public async Task<IActionResult> CreateUser([FromBody] RegisterRequestDto dto)
    {
        var result = await _authenticationService.RegisterByTokenAsync(dto);

        return Ok(result);
    }


    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestDto dto)
    {
        var result = await _authenticationService.LoginByTokenAsync(dto);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromQuery] string id)
    {
        var result = await _userService.DeleteAsync(id);
        return Ok(result);
    }


    [HttpPut("changepassword")]
    public async Task<IActionResult> ChangePassword(string id, ChangePasswordRequestDto dto)
    {
        var result = await _userService.ChangePasswordAsync(id, dto);
        return Ok(result);
    }

}