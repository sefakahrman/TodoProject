
using TodoProject.Models.Entities;
using TodoProject.Models.Users;

namespace TodoProject.Service.Abstracts;

public interface IUserService
{
    Task<User> CreateUserAsync(RegisterRequestDto registerRequestDto);



}
