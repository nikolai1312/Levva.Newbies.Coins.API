using Levva.Newbies.Coins.API.Domain.Models;

namespace Levva.Newbies.Coins.API.Data.Interfaces
{
    public interface ICategoryRepository
    {
        Category Create(Category category);
        Category Get(Guid id);
        List<Category> GetAll();
        void Update(Category category);
        void Delete(Guid id);
    }
}
