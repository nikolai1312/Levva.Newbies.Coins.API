using Levva.Newbies.Coins.API.Domain.Models;
using Levva.Newbies.Coins.API.Logic.Dtos;

namespace Levva.Newbies.Coins.API.Logic.Interfaces
{
    public interface ITransactionService
    {
        Transaction Create(Transaction transaction);

        TransactionDto Get(int id);

        List<TransactionDto> GetAll();
        
        void Update(TransactionDto transaction);
        
        void Delete(int id);

    }
}
