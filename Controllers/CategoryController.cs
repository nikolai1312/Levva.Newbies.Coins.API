using Levva.Newbies.Coins.API.Domain.Models;
using Levva.Newbies.Coins.API.Logic.Dtos;
using Levva.Newbies.Coins.API.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Levva.Newbies.Coins.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpPost("Create")]
        public ActionResult<Category> Create(CategoryDto category)
        {
            var _createdCategory = _service.Create(category);
            return Created("", _createdCategory);
        }

        [HttpGet]
        public ActionResult<CategoryDto> Get(Guid id)
        {
                var _category = _service.Get(id);
            return Ok(_category);
        }

        [HttpGet("list")]
        public ActionResult<List<CategoryDto>> GetAll(Guid id)
        {
                List<CategoryDto> _category = _service.GetAll();
            return Ok(_category);
        }

        [HttpPut]
        public IActionResult Update(CategoryDto category)
        {
            _service.Update(category);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
