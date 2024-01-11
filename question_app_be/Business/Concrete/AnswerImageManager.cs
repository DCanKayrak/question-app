using Business.Abstract;
using Business.Constants;
using Business.DependencyResolvers.Mapper;
using Core.Entity.Abstract;
using Core.Helpers;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete.Dto.Response;
using Entities.Concrete.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Business.Concrete
{
    public class AnswerImageManager : IAnswerImageService
    {
        private IFileHelper _fileHelper;
        private IAnswerImageRepository _answerImageRepository;

        public AnswerImageManager(
            IAnswerImageRepository answerImageRepository,
            IFileHelper fileHelper)
        {
            _fileHelper = fileHelper;
            _answerImageRepository = answerImageRepository;
        }

        public IResult Add(IFormFile file, AnswerImage entity)
        {
            entity.FilePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            _answerImageRepository.Create(entity);
            return new SuccessResult(Message.ImageUploaded);
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<AnswerImageResponse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<AnswerImageResponse> GetByImageId(int id)
        {
            return new SuccessDataResult<AnswerImageResponse>(MapperHelper<AnswerImage, AnswerImageResponse>.Map(_answerImageRepository.Get(i => i.Id == id)));
        }

        public string GetImagePathById(int id)
        {
            return _answerImageRepository.Get(i => i.Id == id).FilePath;
        }

        public IResult Update(IFormFile file, AnswerImage entity)
        {
            throw new NotImplementedException();
        }
    }
}
