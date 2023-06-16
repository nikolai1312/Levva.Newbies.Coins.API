using Levva.Newbies.Coins.API.Domain.Enum;

namespace Levva.Newbies.Coins.API.Logic.Dtos
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public TransactionTypeEnum Type { get; set; }
        public virtual CategoryDto? Category { get; set; }

    }
}
