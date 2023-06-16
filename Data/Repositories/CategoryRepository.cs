using Levva.Newbies.Coins.API.Data.Interfaces;
using Levva.Newbies.Coins.API.Domain.Models;

namespace Levva.Newbies.Coins.API.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context)
        {
            _context = context;
        }
        public Category Create(Category category)
        {
            _context.Category.Add(category);
            _context.SaveChanges();
            return category;
        }

        public void Delete(int id)
        {
            var _category = _context.Category.Find(id);
            _context.Category.Remove(_category);
            _context.SaveChanges();
        }

        public Category Get(int id)
        {
            return _context.Category.Find(id);
        }

        public List<Category> GetAll()
        {
            return _context.Category.ToList();
        }

        public void Update(Category category)
        {
            _context.Category.Update(category);
            _context.SaveChanges();
        }
    }
}
