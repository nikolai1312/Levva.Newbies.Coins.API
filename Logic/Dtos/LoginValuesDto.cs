using System.Globalization;

namespace Levva.Newbies.Coins.API.Logic.Dtos
{
    public class LoginValuesDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string? Token { get; set; }
        public string? Name { get; set; }
    }
}
