using AutoMapper;
using Levva.Newbies.Coins.API.Domain.Models;
using Levva.Newbies.Coins.API.Logic.Dtos;

namespace Levva.Newbies.Coins.API.Logic.MapperProfiles
{
    public class DefaultMapper : Profile
    {
        public DefaultMapper() {

            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<NewAccountDto, User>().ReverseMap();
            CreateMap<TransactionDto, Transaction>().ReverseMap();
            CreateMap<NewTransactionDto, Transaction>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<NewCategoryDto, Category>().ReverseMap();

        }
    }
}
