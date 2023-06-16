using Levva.Newbies.Coins.API.Domain.Models;
using Levva.Newbies.Coins.API.Logic.Dtos;

namespace Levva.Newbies.Coins.API.Logic.Interfaces
{
    public interface ITransactionService
    {
        TransactionDto Create(int userId, NewTransactionDto transacao);

        TransactionDto Get(int id);

        List<TransactionDto> GetAll();

        public List<TransactionDto> SearchDescription(string query);

        void Update(TransactionDto transaction);
        
        void Delete(int id);

    }
}
