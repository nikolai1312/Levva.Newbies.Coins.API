using Levva.Newbies.Coins.API.Logic.Dtos;
using Levva.Newbies.Coins.API.Logic.Interfaces;
using Levva.Newbies.Coins.API.Logic.Services;
using Microsoft.AspNetCore.Mvc;

namespace Levva.Newbies.Coins.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _service;
        public TransactionController(TransactionService service)
        {
            _service = service;
        }
        [HttpPost("Create")]
        public IActionResult Create(TransactionDto transaction)
        {
            _service.Create(transaction);
            return Created("", transaction);
        }
        [HttpGet]
        public ActionResult<TransactionDto> Get(int id)
        {
            var _transaction = _service.Get(id);
            return Ok(_transaction);
        }
        [HttpGet("list")]
        public ActionResult<List<TransactionDto>> GetAll(int id)
        {
            List<TransactionDto> _transaction = _service.GetAll();
            return Ok(_transaction);
        }
        [HttpPut]
        public IActionResult Update(TransactionDto transaction)
        {
            _service.Update(transaction);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
