using Core.Utilities.Results.Abstract;
using Entities.Concrete.Dto.Response;
using Entities.Concrete.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAnswerImageService
    {
        IResult Add(IFormFile file, AnswerImage entity);
        IResult Delete(int id);
        IResult Update(IFormFile file, AnswerImage entity);
        IDataResult<List<AnswerImageResponse>> GetAll();
        IDataResult<AnswerImageResponse> GetByImageId(int id);
        string GetImagePathById(int id);
    }
}
