using Business.Abstract;
using Business.DependencyResolvers.Mapper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto.Response;
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
        private IQuestionRepository _questionRepository;

        public AnswerManager(
            IAnswerRepository answerRepository, 
            IUserService userService,
            IQuestionRepository questionRepository)
        {
            _answerRepository = answerRepository;
            _userService = userService;
            _questionRepository = questionRepository;

        }
        public IDataResult<AnswerResponse> Create(Answer entity)
        {
            entity.UserId = _userService.GetAuthUser().Id;
            Question question = _questionRepository.Get(q=>q.Id == entity.QuestionId);
            question.Status = false;
            _questionRepository.Update(question);
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
