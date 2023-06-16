namespace Levva.Newbies.Coins.API.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual List<Transaction> Transaction { get; set; }
    }
}
