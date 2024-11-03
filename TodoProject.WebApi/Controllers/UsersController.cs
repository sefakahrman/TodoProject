using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoProject.Models.Users;
using TodoProject.Service.Abstracts;

namespace TodoProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(IUserService _userService) : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody]RegisterRequestDto dto)
        {
            var result = await _userService.CreateUserAsync(dto);

            return Ok(result);
        }


    }
}
