using Levva.Newbies.Coins.API.Domain.Models;

namespace Levva.Newbies.Coins.API.Data.Interfaces
{
    public interface ITransactionRepository
    {
        void Create(Transaction transaction);
        Transaction Get(int id);
        List<Transaction> GetAll();
        void Update(Transaction transaction);
        void Delete(int id);
    }
}
