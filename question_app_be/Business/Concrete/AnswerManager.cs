using Business.Abstract;
using Business.BusinessAspects;
using Business.DependencyResolvers.Mapper;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto.Response;
using Entities.Concrete.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AnswerManager : IAnswerService
    {
        private IAnswerRepository _answerRepository;
        private IUserService _userService;
        private IQuestionService _questionService;

        public AnswerManager(
            IAnswerRepository answerRepository, 
            IUserService userService,
            IQuestionService questionService)
        {
            _answerRepository = answerRepository;
            _userService = userService;
            _questionService = questionService;

        }

        [SecuredOperation("Öğretmen")]
        [ValidationAspect(typeof(AnswerValidator))]
        public IDataResult<AnswerResponse> Create(Answer entity)
        {
            entity.UserId = _userService.GetAuthUser().Id;
            _questionService.ChangeStatus(entity.UserId);
            entity.CreationTime = DateTime.Now;
            _answerRepository.Create(entity);
            return new SuccessDataResult<AnswerResponse>(MapperHelper<Answer,AnswerResponse>.Map(entity));
        }

        public IResult Delete(int id)
        {
            _answerRepository.Delete(_answerRepository.Get(a=>a.Id == id));
            return new SuccessResult();
        }

        public IDataResult<AnswerResponse> Get(int id)
        {
            return new SuccessDataResult<AnswerResponse>(MapperHelper<Answer,AnswerResponse>.Map(_answerRepository.Get(a => a.Id == id)));
        }

        public IDataResult<List<AnswerResponse>> GetAll()
        {
            return new SuccessDataResult<List<AnswerResponse>>(MapperHelper<Answer,AnswerResponse>.MapList(_answerRepository.GetAll(null)));
        }

        public IResult Update(Answer entity)
        {
            _answerRepository.Update(entity);
            return new SuccessResult();
        }
    }
}
