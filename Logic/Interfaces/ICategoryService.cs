using Levva.Newbies.Coins.API.Domain.Models;
using Levva.Newbies.Coins.API.Logic.Dtos;

namespace Levva.Newbies.Coins.API.Logic.Interfaces
{
    public interface ICategoryService
    {
        CategoryDto Create(NewCategoryDto category);

        CategoryDto Get(int id);

        List<CategoryDto> GetAll();

        void Update(CategoryDto category);

        void Delete(int id);

    }
}
