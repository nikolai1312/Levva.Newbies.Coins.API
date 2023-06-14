using Levva.Newbies.Coins.API.Domain.Enum;

namespace Levva.Newbies.Coins.API.Logic.Dtos
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public TransactionTypeEnum Type { get; set; }
        public int CategoryId { get; set; }
        public virtual CategoryDto? Category { get; set; }
        public int UserId { get; set; }
        public virtual UserDto? User { get; set; }

    }
}
