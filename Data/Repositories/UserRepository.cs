using Levva.Newbies.Coins.API.Data.Interfaces;
using Levva.Newbies.Coins.API.Domain.Models;

namespace Levva.Newbies.Coins.API.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;
        public UserRepository(Context context)
        {
            _context = context;
        }
        public void Create(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            var _user = _context.User.Find(id);
            _context.User.Remove(_user);
            _context.SaveChanges();
        }

        public User Get(int id)
        {
            return _context.User.Find(id);
        }

        public List<User> GetAll()
        {
            return _context.User.ToList();
        }

        public void Update(User user)
        {
            _context.User.Update(user);
            _context.SaveChanges();
        }

        public User GetByEmailAndPassword(string email, string passwd)
        {
            return _context.User.FirstOrDefault(x => x.Email.Equals(email) && x.Password.Equals(passwd));
        }
    }
}
