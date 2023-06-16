using Levva.Newbies.Coins.API.Domain.Models;
using Levva.Newbies.Coins.API.Logic.Dtos;
using Levva.Newbies.Coins.API.Logic.Interfaces;
using Levva.Newbies.Coins.API.Logic.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Levva.Newbies.Coins.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _service;
        private readonly ICategoryService _categoryService;

        public TransactionController(ITransactionService service, ICategoryService categoryService)
        {
            _service = service;
            _categoryService = categoryService;
        }

        [HttpPost("Create")]
        public IActionResult Create(NewTransactionDto transaction)
        {
            var _userId = User.Identity!.Name;
            var _category = _categoryService.Get(transaction.CategoryId);
            var _transaction = _service.Create(Convert.ToInt32(_userId), transaction);
            _transaction.Category = _category;
            return Created("", _transaction);
        }

        [HttpGet("{SearchParams}")]
        public ActionResult<List<TransactionDto>> Get(string SearchParams)
        {
            return _service.SearchDescription(SearchParams);
        }

        [HttpGet("list")]
        public ActionResult<List<TransactionDto>> GetAll(int id)
        {

            return _service.GetAll();
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
