using Levva.Newbies.Coins.API.Domain.Models;
using Levva.Newbies.Coins.API.Logic.Dtos;
using Levva.Newbies.Coins.API.Logic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Levva.Newbies.Coins.API.Controllers
{
    [Authorize]
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
        public IActionResult Create(NewCategoryDto category)
        {
            var _createdCategory = _service.Create(category);
            return Created("", _createdCategory);
        }

        [HttpGet]
        public ActionResult<CategoryDto> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpGet("list")]
        public ActionResult<List<CategoryDto>> GetAll(int id)
        {
            return _service.GetAll();
        }

        [HttpPut]
        public IActionResult Update(CategoryDto category)
        {
            _service.Update(category);
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
