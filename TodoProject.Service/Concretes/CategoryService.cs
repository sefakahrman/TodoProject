
using AutoMapper;
using Core.Entities.ReturnModel;
using TodoProject.Models.Dtos.Category;
using TodoProject.Models.Entities;
using TodoProject.Repository.Repositories.Abstracts;
using TodoProject.Service.Abstracts;

namespace TodoProject.Service.Concretes;

public sealed class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public ReturnModel<CategoryResponseDto> Add(CreateCategoryRequestDto dto)
    {
        Category createdCategory = _mapper.Map<Category>(dto);


        Category category = _categoryRepository.Add(createdCategory);
        CategoryResponseDto response = _mapper.Map<CategoryResponseDto>(category);

        return new ReturnModel<CategoryResponseDto>
        {
            Data = response,
            Message = "Kategori Eklendi",
            Status = 200,
            Success = true
        };
    }

    public ReturnModel<List<CategoryResponseDto>> GetAll()
    {
        List<Category> categories = _categoryRepository.GetAll();
        List<CategoryResponseDto> response = _mapper.Map<List<CategoryResponseDto>>(categories);

        return new ReturnModel<List<CategoryResponseDto>>
        {
            Data = response,
            Message = "Kategoriler başarıyla getirildi",
            Status = 200,
            Success = true
        };
    }

    public ReturnModel<CategoryResponseDto> GetById(int id)
    {
        Category category = _categoryRepository.GetById(id);

        if (category == null)
        {
            return new ReturnModel<CategoryResponseDto>
            {
                Data = null,
                Message = "Kategori bulunamadı",
                Status = 404,
                Success = false
            };
        }

        CategoryResponseDto response = _mapper.Map<CategoryResponseDto>(category);

        return new ReturnModel<CategoryResponseDto>
        {
            Data = response,
            Message = "Kategori başarıyla getirildi",
            Status = 200,
            Success = true
        };
    }
}
}
