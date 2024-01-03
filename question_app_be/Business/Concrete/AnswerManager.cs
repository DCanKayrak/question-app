using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public IDataResult<Answer> Create(Answer entity)
        {
            entity.UserId = _userService.GetAuthUser().Id;
            Question question = _questionService.Get(entity.QuestionId).Data;
            question.Status = false;
            _questionService.Update(question);
            _answerRepository.Create(entity);
            return new SuccessDataResult<Answer>(entity);
        }

        public IResult Delete(int id)
        {
            _answerRepository.Delete(this.Get(id).Data);
            return new SuccessResult();
        }

        public IDataResult<Answer> Get(int id)
        {
            return new SuccessDataResult<Answer>(_answerRepository.Get(a => a.Id == id));
        }

        public IDataResult<List<Answer>> GetAll()
        {
            return new SuccessDataResult<List<Answer>>(_answerRepository.GetAll(null));
        }

        public IResult Update(Answer entity)
        {
            _answerRepository.Update(entity);
            return new SuccessResult();
        }
    }
}
