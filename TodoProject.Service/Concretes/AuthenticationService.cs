﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Models.Dtos.Tokens;
using TodoProject.Models.Dtos.Users;
using TodoProject.Service.Abstracts;

namespace TodoProject.Service.Concretes;


public class AuthenticationService : IAuthenticationService
{
    private readonly IUserService _userService;
    private readonly IJwtService _jwtService;

    public AuthenticationService(IUserService userService, IJwtService jwtService)
    {
        _userService = userService;
        _jwtService = jwtService;
    }

    public async Task<TokenResponseDto> LoginByTokenAsync(LoginRequestDto dto)
    {
        var loginResponse = await _userService.LoginAsync(dto);
        var tokenResponse = await _jwtService.CreateToken(loginResponse);
        return tokenResponse;
    }

    public async Task<TokenResponseDto> RegisterByTokenAsync(RegisterRequestDto dto)
    {
        var registerResponse = await _userService.CreateUserAsync(dto);
        var tokenResponse = await _jwtService.CreateToken(registerResponse);
        return tokenResponse;
    }
}