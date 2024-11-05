using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoProject.Models.Dtos.Category;
using TodoProject.Models.Dtos.Todo;
using TodoProject.Service.Abstracts;
using TodoProject.Service.Concretes;

namespace TodoProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController(ITodoService todoService) : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult Add([FromBody] CreateTodoRequestDto dto)
        {
            var result = todoService.Add(dto);
            return Ok(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = todoService.GetAll();

            return Ok(result);
        }


        [HttpGet("getbyid/{id:int}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var result = todoService.GetById(id);

            return Ok(result);
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] UpdatedTodoRequestDto dto)
        {
            var result = todoService.Update(dto);
            return Ok(result);
        }


        [HttpDelete("Delete")]
        public IActionResult Delete([FromBody] Guid id)
        {
            var result = todoService.Delete(id);
            return Ok(result);
        }
    }
}
