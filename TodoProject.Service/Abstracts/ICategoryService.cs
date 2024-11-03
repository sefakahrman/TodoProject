
using Core.Entities.ReturnModel;
using TodoProject.Models.Dtos.Category;
using TodoProject.Models.Dtos.Todo;

namespace TodoProject.Service.Abstracts;

public interface ICategoryService 
{
    ReturnModel<CategoryResponseDto> Add(CreateCategoryRequestDto dto);
    ReturnModel<List<CategoryResponseDto>> GetAll();
    ReturnModel<CategoryResponseDto> GetById(int id);
}
