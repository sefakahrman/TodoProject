
using Core.Entities;
using Core.Entities.ReturnModel;
using System.Xml.Linq;
using TodoProject.Models.Dtos.Category;
using TodoProject.Models.Dtos.Todo;

namespace TodoProject.Service.Abstracts;

public interface ICategoryService 
{
    ReturnModel<List<CategoryResponseDto>> GetAllCategories();
    ReturnModel<CategoryResponseDto> GetById(int id);
    ReturnModel<NoData> Add(CategoryAddRequestDto dto);
    ReturnModel<NoData> Update(CategoryUpdateRequestDto dto);

    ReturnModel<NoData> Delete(int id);
}
