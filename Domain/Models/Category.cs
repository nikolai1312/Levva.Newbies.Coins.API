namespace Levva.Newbies.Coins.API.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual List<Transaction> Transaction { get; set; }
    }
}
