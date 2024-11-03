
using AutoMapper;
using TodoProject.Models.Dtos.Category;
using TodoProject.Models.Dtos.Todo;
using TodoProject.Models.Entities;

namespace TodoProject.Service.Mappings;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateTodoRequestDto,Todo>();
        CreateMap<Todo,TodoResponseDto>();
        CreateMap<CreateCategoryRequestDto,Category>();
        CreateMap<Category,CategoryResponseDto>();
    }
}
