using Levva.Newbies.Coins.API.Logic.Dtos;
using Levva.Newbies.Coins.API.Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Levva.Newbies.Coins.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("Create")]
        [AllowAnonymous]
        public IActionResult Create(NewAccountDto user)
        {
            _service.Create(user);
            return Created("", user);
        }

        [HttpGet]
        public ActionResult<UserDto> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpGet("list")]
        public ActionResult<List<UserDto>> GetAll(int id)
        {
            return _service.GetAll();
        }

        [HttpPut]
        public IActionResult Update(UserDto user)
        {
            _service.Update(user);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult<LoginValuesDto> Login(LoginDto loginDto)
        {
            var _login = _service.Login(loginDto);
            if (_login == null)
                return BadRequest("Usuário ou senha inválidos");
            return Ok(_login);
        }
    }
}
