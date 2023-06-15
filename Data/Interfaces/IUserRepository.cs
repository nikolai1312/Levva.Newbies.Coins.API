using Levva.Newbies.Coins.API.Domain.Models;

namespace Levva.Newbies.Coins.API.Data.Interfaces
{
    public interface IUserRepository
    {
        User Get(int id);
        User GetByEmailAndPassword(string email, string passwd);
        List<User> GetAll();
        void Delete(int id);
        void Create(User user);
        void Update(User user);
    }
}
