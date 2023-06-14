using Levva.Newbies.Coins.API.Logic.Dtos;

namespace Levva.Newbies.Coins.API.Logic.Interfaces
{
    public interface ITransactionService
    {
        void Create(TransactionDto transaction);

        TransactionDto Get(int id);

        List<TransactionDto> GetAll();
        
        void Update(TransactionDto transaction);
        
        void Delete(int id);

    }
}
