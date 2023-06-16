using Levva.Newbies.Coins.API.Domain.Enum;

namespace Levva.Newbies.Coins.API.Domain.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public TransactionTypeEnum Type { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public int? UserId { get; set; }
        public virtual User? User { get; set; }
    
    }
}
