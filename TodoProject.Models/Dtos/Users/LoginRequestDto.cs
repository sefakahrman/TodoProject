namespace TodoProject.Models.Dtos.Users;

public sealed record LoginRequestDto(string UserName,string Email, string Password)
{
}
