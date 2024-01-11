using Business.Abstract;
using Business.DependencyResolvers.Mapper;
using Entities.Concrete;
using Entities.Concrete.Dto.Request;
using Entities.Concrete.Dto.Response;
using Entities.Concrete.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerImageController : ControllerBase
    {
        private IAnswerImageService _answerImageService;
        private static IWebHostEnvironment _webHostEnvironment;

        public AnswerImageController(
            IAnswerImageService answerImageService,
            IWebHostEnvironment webHostEnvironment)
        {
            _answerImageService = answerImageService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = _answerImageService.GetByImageId(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            string path = _webHostEnvironment.WebRootPath + "\\Uploads\\Images\\" + _answerImageService.GetImagePathById(id);
            if (System.IO.File.Exists(path))
            {
                var resimBytes = System.IO.File.ReadAllBytes(path);
                return File(resimBytes, "image/jpg"); // Resim türüne göre uygun MIME tipini seçin
            }
            return null;
        }

        [HttpPost]
        public IActionResult Create([FromForm] CreateAnswerImgDto req)
        {
            var result = _answerImageService.Add(req.file, MapperHelper<CreateAnswerImgDto,AnswerImage>.Map(req));
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
    }
}
