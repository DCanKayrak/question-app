using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.Dto.Response;
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
        private IUserService _userService;
        private IMapper _mapper;
        
        public QuestionManager(
            IQuestionRepository questionRepository,
            IUserService userService,
            IMapper mapper)
        {
            _questionRepository = questionRepository;
            _userService = userService;
            _mapper = mapper;
        }

        public IDataResult<Question> Create(Question entity)
        {
            entity.UserId = _userService.GetAuthUser().Id;
            _questionRepository.Create(entity);
            return new SuccessDataResult<Question>(entity,Message.QuestionCreated);
        }

        public IResult Delete(int id)
        {
            _questionRepository.Delete(_questionRepository.Get(p => p.Id == id));
            return new SuccessResult();
        }

        public IDataResult<Question> Get(int id)
        {
            return new SuccessDataResult<Question>(_questionRepository.Get(q => q.Id == id));
        }

        public IDataResult<List<Question>> GetAll()
        {
            return new SuccessDataResult<List<Question>>(_questionRepository.GetAll(null),Message.QuestionGetAllSuccess);
        }

        public IResult Update(Question request)
        {
            _questionRepository.Update(request);
            return new SuccessResult();
        }
    }
}
