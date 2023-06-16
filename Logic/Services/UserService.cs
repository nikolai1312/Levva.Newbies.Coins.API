using AutoMapper;
using Levva.Newbies.Coins.API.Data.Interfaces;
using Levva.Newbies.Coins.API.Domain.Models;
using Levva.Newbies.Coins.API.Logic.Dtos;
using Levva.Newbies.Coins.API.Logic.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Levva.Newbies.Coins.API.Logic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public UserService(IUserRepository repository, IMapper mapper, IConfiguration configuration)
        {
            _repository = repository;
            _mapper = mapper;
            _configuration = configuration;
        }

        public void Create(NewAccountDto user)
        {
            var _user = _mapper.Map<User>(user);
            _repository.Create(_user);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public UserDto Get(int id)
        {
            var _user = _mapper.Map<UserDto>(_repository.Get(id));
            return _user;
        }

        public List<UserDto> GetAll()
        {
            var _user = _mapper.Map<List<UserDto>>(_repository.GetAll());
            return _user;
        }
        public void Update(UserDto user)
        {
            var _user = _mapper.Map<User>(user);
            _repository.Update(_user);
        }

        public LoginValuesDto Login(LoginDto login)
        {
            var _user = _repository.GetByEmailAndPassword(login.Email, login.Password);
            if (_user == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration.GetSection("Secret").Value);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, _user.Id.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, _user.Name),
                    new Claim(ClaimTypes.Email, _user.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var _loginValues = new LoginValuesDto { Id = _user.Id, Email = _user.Email, Name = _user.Name };
            _loginValues.Token = $"Bearer {tokenHandler.WriteToken(token)}";

            return _loginValues;
        }

    }
}
