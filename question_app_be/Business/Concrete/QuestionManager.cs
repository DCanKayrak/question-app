using AutoMapper;
using Business.Abstract;
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
        private IMapper _mapper;

        public QuestionManager(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public BaseResponse<Question> Create(Question entity)
        {
            _questionRepository.Create(entity);
            return new BaseResponse<Question>(entity);
        }

        public BaseResponse<Boolean> Delete(int id)
        {
            _questionRepository.Delete(_questionRepository.Get(p => p.Id == id));
            return new BaseResponse<bool>(true);
        }

        public BaseResponse<Question> Get(int id)
        {
            return new BaseResponse<Question>(_questionRepository.Get(q => q.Id == id));
        }

        public BaseResponse<List<Question>> GetAll()
        {
            return new BaseResponse<List<Question>>(_questionRepository.GetAll(null));
        }

        public BaseResponse<Boolean> Update(Question request)
        {
            _questionRepository.Update(request);
            return new BaseResponse<bool>(true);
        }
    }
}
