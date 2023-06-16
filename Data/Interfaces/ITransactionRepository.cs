using Levva.Newbies.Coins.API.Domain.Models;

namespace Levva.Newbies.Coins.API.Data.Interfaces
{
    public interface ITransactionRepository
    {
        Transaction Create(Transaction transaction);
        Transaction Get(int id);
        List<Transaction> GetAll();
        public ICollection<Transaction> SearchByDescription(string query);
        void Update(Transaction transaction);
        void Delete(int id);
    }
}
