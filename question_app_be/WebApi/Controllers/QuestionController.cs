using AutoMapper;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Validation;
using Entities.Concrete;
using Entities.Concrete.Dto.Request.Question;
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
            return Ok(_questionService.GetAll());
        }

        // GET api/<QuestionController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_questionService.Get(id));
        }

        // POST api/<QuestionController>
        [HttpPost]
        [ValidationAspect(typeof(QuestionValidator))]
        public IActionResult Post([FromBody] CreateQuestionDto request)
        {
            return Ok(_questionService.Create(_mapper.Map<Question>(request)));
        }

        // PUT api/<QuestionController>/5
        [HttpPut]
        public IActionResult Put([FromBody] UpdateQuestionDto request)
        {
            _questionService.Update(_mapper.Map<Question>(request));
            return Ok();
        }

        // DELETE api/<QuestionController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _questionService.Delete(id);
            return Ok();
        }
    }
}
