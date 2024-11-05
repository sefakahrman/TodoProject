
using TodoProject.Models.Dtos.Users;
using TodoProject.Models.Entities;

namespace TodoProject.Service.Abstracts;

public interface IUserService
{
    Task<User> CreateUserAsync(RegisterRequestDto registerRequestDto);

    Task<User> LoginAsync(LoginRequestDto dto);

    Task<string> DeleteAsync(string id);

    Task<string> ChangePasswordAsync(string id, ChangePasswordRequestDto dto);

}
