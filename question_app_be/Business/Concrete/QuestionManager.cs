﻿using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.DependencyResolvers.Mapper;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Validation;
using Core.Entity.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.Dto.Response;
using Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        private IQuestionRepository _questionRepository;
        private ICategoryRepository _categoryRepository;
        private IAnswerRepository _answerRepository;
        private IUserService _userService;
        private IMapper _mapper;
        
        public QuestionManager(
            IQuestionRepository questionRepository,
            IUserService userService,
            ICategoryRepository categoryRepository,
            IAnswerRepository answerRepository,
            IMapper mapper)
        {
            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
            _categoryRepository = categoryRepository;
            _userService = userService;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(QuestionValidator))]
        public IDataResult<QuestionResponse> Create(Question entity)
        {
                CategoryResponse category = MapperHelper<Category,CategoryResponse>.Map(_categoryRepository.Get(c => c.Id == entity.CategoryId));

                entity.UserId = _userService.GetAuthUser().Id;
                entity.CreationTime = DateTime.UtcNow;
                UserResponse user = _mapper.Map<UserResponse>(_userService.Get(entity.UserId).Data);

                _questionRepository.Create(entity);

                var result = _mapper.Map<QuestionResponse>(entity);
                result.Category = category;
                result.User = user;

                return new SuccessDataResult<QuestionResponse>(result, Message.QuestionCreated);
        }

        public IResult Delete(int id)
        {
            _questionRepository.Delete(_questionRepository.Get(p => p.Id == id));
            return new SuccessResult();
        }

        public IDataResult<QuestionResponse> Get(int id)
        {
            Question q = _questionRepository.Get(q => q.Id == id);
            CategoryResponse category = _mapper.Map<CategoryResponse>(_categoryRepository.Get(c => c.Id == q.CategoryId));
            UserResponse user = _mapper.Map<UserResponse>(_userService.Get(q.UserId).Data);
            AnswerResponse answer = _mapper.Map<AnswerResponse>(_answerRepository.Get(a => a.QuestionId == q.Id));

            var result = _mapper.Map<QuestionResponse>(q);
            result.Category = category;
            result.Answer = answer;
            result.User = user;

            return new SuccessDataResult<QuestionResponse>(result);
        }

        public IDataResult<List<QuestionResponse>> GetWithString(string q)
        {
            List<Question> questions = _questionRepository.GetAll(tq => tq.Title.Contains(q));
            return new SuccessDataResult<List<QuestionResponse>>(MapperHelper<Question,QuestionResponse>.MapList(questions));
        }

        public IDataResult<List<QuestionResponse>> GetAll()
        {
            var result = new List<QuestionResponse>();
            foreach (Question q in _questionRepository.GetAll(null))
            {
                CategoryResponse category = _mapper.Map<CategoryResponse>(_categoryRepository.Get(c => c.Id == q.CategoryId));
                UserResponse user = _userService.Get(q.UserId).Data;
                AnswerResponse answer = _mapper.Map<AnswerResponse>(_answerRepository.Get(a => a.QuestionId == q.Id));

                var res = _mapper.Map<QuestionResponse>(q);
                res.Category = category;
                res.User = user;
                res.Answer = answer;
                result.Add(res);
            }

            return new SuccessDataResult<List<QuestionResponse>>(result,Message.QuestionGetAllSuccess);
        }

        [ValidationAspect(typeof(QuestionValidator))]
        public IResult Update(Question request)
        {
            _questionRepository.Update(request);
            return new SuccessResult();
        }

        public IResult ChangeStatus(int id)
        {
            var question = _questionRepository.Get(q => q.Id == id);
            question.Status = false;
            _questionRepository.Update(question);
            return new SuccessResult();
        }
    }
}
