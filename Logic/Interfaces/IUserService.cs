using Levva.Newbies.Coins.API.Domain.Models;
using Levva.Newbies.Coins.API.Logic.Dtos;

namespace Levva.Newbies.Coins.API.Logic.Interfaces
{
    public interface IUserService
    {
        User Create(NewAccountDto user);
        UserDto Get(int id);
        List<UserDto> GetAll();
        void Update(UserDto user);
        void Delete(int id);
        LoginDto Login(LoginDto loginDto);
    }
}
