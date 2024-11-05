
using Core.Entities.ReturnModel;
using TodoProject.Models.Dtos.Todo;
using TodoProject.Models.Entities;

namespace TodoProject.Service.Abstracts;

public interface ITodoService
{
    ReturnModel<TodoResponseDto> Add(CreateTodoRequestDto dto);
    ReturnModel<List<TodoResponseDto>> GetAll();
    ReturnModel<TodoResponseDto> GetById(Guid id);

    ReturnModel<TodoResponseDto> Update(UpdatedTodoRequestDto dto);
    ReturnModel<string> Delete(Guid id);
}
