
using AutoMapper;
using Core.Entities.ReturnModel;
using TodoProject.Models.Dtos.Todo;
using TodoProject.Models.Entities;
using TodoProject.Repository.Repositories.Abstracts;
using TodoProject.Service.Abstracts;

namespace TodoProject.Service.Concretes;

public sealed class TodoService : ITodoService
{
    private readonly ITodoRepository _todoRepository;

    private readonly IMapper _mapper;

    public TodoService(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public TodoService(ITodoRepository todoRepository, IMapper mapper)
    {
        _todoRepository = todoRepository;
        _mapper = mapper;
    }

    public ReturnModel<TodoResponseDto> Add(CreateTodoRequestDto dto)
    {
        Todo createdTodo = _mapper.Map<Todo>(dto);
        createdTodo.Id = Guid.NewGuid();

        Todo todo = _todoRepository.Add(createdTodo);
        TodoResponseDto response = _mapper.Map<TodoResponseDto>(todo);

        return new ReturnModel<TodoResponseDto>
        {
            Data = response,
            Message = "Görev Eklendi",
            Status = 200,
            Success = true
        };
    }

    public ReturnModel<string> Delete(Guid id)
    {
        Todo? todo = _todoRepository.GetById(id);
        Todo deletedTodo = _todoRepository.Delete(todo);

        return new ReturnModel<string>
        {
            Data = $"Todo Başlığı : {deletedTodo.Title}",
            Message = "Silindi",
            Status = 204,
            Success = true
        };
    }

    public ReturnModel<List<TodoResponseDto>> GetAll()
    {
        List<Todo> todos = _todoRepository.GetAll();

        List<TodoResponseDto> response = _mapper.Map<List<TodoResponseDto>>(todos);

        return new ReturnModel<List<TodoResponseDto>>
        {
            Data = response,
            Message = "Görevler başarıyla getirildi",
            Status = 200,
            Success = true
        };
    }

    public ReturnModel<TodoResponseDto> GetById(Guid id)
    {
        Todo todo = _todoRepository.GetById(id);

        if (todo == null)
        {
            return new ReturnModel<TodoResponseDto>
            {
                Data = null,
                Message = "Görev bulunamadı",
                Status = 404,
                Success = false
            };
        }

        TodoResponseDto response = _mapper.Map<TodoResponseDto>(todo);

        return new ReturnModel<TodoResponseDto>
        {
            Data = response,
            Message = "Görev başarıyla getirildi",
            Status = 200,
            Success = true
        };
    }

    public ReturnModel<TodoResponseDto> Update(UpdatedTodoRequestDto dto)
    {

        Todo todo = _todoRepository.GetById(dto.Id);

        todo.Title = dto.Title;
        todo.Description = dto.Description;
        todo.Priority = dto.Priority;
        todo.CategoryId = dto.CategoryId;
        todo.CreatedDate = DateTime.Now;
      

        _todoRepository.Update(todo);

        TodoResponseDto response = _mapper.Map<TodoResponseDto>(todo);

        return new ReturnModel<TodoResponseDto>
        {
            Data = response,
            Message = "Todo Güncellendi.",
            Status = 200,
            Success = true
        };
    }
}
