using AutoMapper;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto.Request.Category;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;
        private IMapper _mapper;
        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_categoryService.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_categoryService.Get(id));
        }

        [HttpPost]
        public IActionResult Create(CreateCategoryDto req)
        {   
                return Ok(_categoryService.Create(_mapper.Map<Category>(req)));
        }
        [HttpPut]
        public IActionResult Update(UpdateCategoryDto req)
        {
                _categoryService.Update(_mapper.Map<Category>(req));
                return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
                _categoryService.Delete(id);
                return Ok();        
        }
    }
}
