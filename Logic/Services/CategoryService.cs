using AutoMapper;
using Levva.Newbies.Coins.API.Data.Interfaces;
using Levva.Newbies.Coins.API.Domain.Models;
using Levva.Newbies.Coins.API.Logic.Dtos;
using Levva.Newbies.Coins.API.Logic.Interfaces;

namespace Levva.Newbies.Coins.API.Logic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CategoryDto Create(NewCategoryDto category)
        {
            var _category = _mapper.Map<Category>(category);
            return _mapper.Map<CategoryDto>(_repository.Create(_category));

        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public CategoryDto Get(int id)
        {
            var _category = _mapper.Map<CategoryDto>(_repository.Get(id));
            return _category;
        }

        public List<CategoryDto> GetAll()
        {
            var _categories = _mapper.Map<List<CategoryDto>>(_repository.GetAll());
            return _categories;
        }

        public void Update(CategoryDto category)
        {
            var _category = _mapper.Map<Category>(category);
            _repository.Update(_category);
        }
    }
}
