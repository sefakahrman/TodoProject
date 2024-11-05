
using AutoMapper;
using TodoProject.Models.Dtos.Todo;
using TodoProject.Models.Entities;

namespace TodoProject.Service.Mappings
{
    public class TodosProfile : Profile
    {
        public TodosProfile()
        {
        CreateMap<CreateTodoRequestDto, Todo>();
        CreateMap<Todo, TodoResponseDto>();
        }
    }
}
