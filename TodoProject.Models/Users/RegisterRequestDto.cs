
namespace TodoProject.Models.Users;

public sealed record RegisterRequestDto(string Name,string LastName,string UserName, string Password, string Email)
{
}
