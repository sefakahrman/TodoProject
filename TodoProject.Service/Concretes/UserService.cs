
using Microsoft.AspNetCore.Identity;
using TodoProject.Models.Entities;
using TodoProject.Models.Users;
using TodoProject.Service.Abstracts;

namespace TodoProject.Service.Concretes;

public class UserService : IUserService
{

    private readonly UserManager<User> _userManager;

    public UserService(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    public async Task<User> CreateUserAsync(RegisterRequestDto registerRequestDto)
    {
        User user = new User()
        {
            Email = registerRequestDto.Email,
            UserName = registerRequestDto.UserName,
        };

        var result = await _userManager.CreateAsync(user,registerRequestDto.Password);

        return user;

    }


}
