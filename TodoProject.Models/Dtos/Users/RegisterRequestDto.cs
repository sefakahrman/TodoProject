namespace TodoProject.Models.Dtos.Users;

public sealed record RegisterRequestDto(string Name, DateTime BirthDate, string LastName, string UserName, string Password, string Email)
{
}
