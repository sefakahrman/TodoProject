
using AutoMapper;
using TodoProject.Models.Dtos.Category;
using TodoProject.Models.Entities;

namespace TodoProject.Service.Mappings
{
    public class CategoriesProfile : Profile
    {        
        public CategoriesProfile()         
        {
        CreateMap<CategoryAddRequestDto, Category>();
        CreateMap<Category, CategoryResponseDto>();
        }

    }
}
