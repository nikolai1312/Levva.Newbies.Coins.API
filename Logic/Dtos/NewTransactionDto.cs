using Levva.Newbies.Coins.API.Domain.Enum;

namespace Levva.Newbies.Coins.API.Logic.Dtos
{
    public class NewTransactionDto
    {
        public string Description { get; set; }
        public double Amount { get; set; }
        public TransactionTypeEnum Type { get; set; }
        public int CategoryId { get; set; }
    }
}
