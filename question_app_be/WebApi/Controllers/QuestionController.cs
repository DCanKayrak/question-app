using AutoMapper;
using Business.Abstract;
using Business.DependencyResolvers.Mapper;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Validation;
using Entities.Concrete;
using Entities.Concrete.Dto.Request.Question;
using Entities.Concrete.Dto.Response;
using Entities.Concrete.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private IQuestionService _questionService;
        private IMapper _mapper;

        public QuestionController(IQuestionService questionService, IMapper mapper)
        {
            _questionService = questionService;
            _mapper = mapper;
        }

        // GET: api/<QuestionController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _questionService.GetAll();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }

        // GET api/<QuestionController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _questionService.Get(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }

        // POST api/<QuestionController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateQuestionDto request)
        {
            var result = _questionService.Create(_mapper.Map<Question>(request));
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }

        // PUT api/<QuestionController>/5
        [HttpPut]
        public IActionResult Put([FromBody] UpdateQuestionDto request)
        {
            var result = _questionService.Update(_mapper.Map<Question>(request));
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }

        // DELETE api/<QuestionController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _questionService.Delete(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
    }
}
