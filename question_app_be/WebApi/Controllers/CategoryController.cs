using AutoMapper;
using Business.Abstract;
using Core.Utilities.ExceptionHandler;
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
            try
            {
                
                return Ok(_categoryService.Create(_mapper.Map<Category>(req)));
            }
            catch (GenericException ex)
            {
                return BadRequest(ex.ErrorResponse.Message);
            }
        }
        [HttpPut]
        public IActionResult Update(UpdateCategoryDto req)
        {
            try
            {
                return Ok(_categoryService.Update(_mapper.Map<Category>(req)));
            }
            catch (GenericException ex)
            {
                return BadRequest(ex.ErrorResponse.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(_categoryService.Delete(id));
            }
            catch (GenericException ex)
            {
                return BadRequest(ex.ErrorResponse.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
