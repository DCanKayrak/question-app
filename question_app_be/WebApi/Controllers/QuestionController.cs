using AutoMapper;
using Business.Abstract;
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
        public ActionResult<List<Question>> GetAll()
        {
            return Ok(_questionService.GetAll());
        }

        // GET api/<QuestionController>/5
        [HttpGet("{id}")]
        public ActionResult<Question> Get(int id)
        {
            return Ok(_questionService.Get(id));
        }

        // POST api/<QuestionController>
        [HttpPost]
        public ActionResult<Question> Post([FromBody] CreateQuestionDto request)
        {
            return Ok(_questionService.Create(_mapper.Map<Question>(request)));
        }

        // PUT api/<QuestionController>/5
        [HttpPut]
        public ActionResult<Boolean> Put([FromBody] UpdateQuestionDto request)
        {
            return Ok(_questionService.Update(_mapper.Map<Question>(request)));
        }

        // DELETE api/<QuestionController>/5
        [HttpDelete("{id}")]
        public ActionResult<Boolean> Delete(int id)
        {
            return Ok(_questionService.Delete(id));
        }
    }
}
