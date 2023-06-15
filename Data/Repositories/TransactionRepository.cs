using Levva.Newbies.Coins.API.Data.Interfaces;
using Levva.Newbies.Coins.API.Domain.Models;

namespace Levva.Newbies.Coins.API.Data.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly Context _context;
        public TransactionRepository(Context context)
        {
            _context = context;
        }
        public Transaction Create(Transaction transaction)
        {
            _context.Transaction.Add(transaction);
            transaction.CreatedAt = DateTime.Now;
            _context.SaveChanges();
            return transaction;
        }

        public void Delete(int id)
        {
            var _transaction = _context.Transaction.Find(id);
            _context.Transaction.Remove(_transaction);
            _context.SaveChanges();
        }

        public Transaction Get(int id)
        {
            return _context.Transaction.Find(id);
        }

        public List<Transaction> GetAll()
        {
            return _context.Transaction.ToList();

        }

        public void Update(Transaction transaction)
        {
            _context.Transaction.Update(transaction);
            _context.SaveChanges();

        }
    }
}
