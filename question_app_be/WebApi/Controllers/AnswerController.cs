using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto.Request.Answer;
using Entities.Concrete.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private IAnswerService _answerService;
        private IMapper _mapper;

        public AnswerController(IAnswerService answerService, IMapper mapper)
        {
            _answerService = answerService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _answerService.GetAll();
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _answerService.Get(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateAnswerDto req)
        {
            var result = _answerService.Create(_mapper.Map<Answer>(req));
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
        [HttpPut]
        public IActionResult Update([FromBody] UpdateAnswerDto req)
        {
            var result = _answerService.Update(_mapper.Map<Answer>(req));
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _answerService.Delete(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
    }
}
