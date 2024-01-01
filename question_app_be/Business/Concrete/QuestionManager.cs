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

        public Question Create(Question entity)
        {
            _questionRepository.Create(entity);
            return entity;
        }

        public void Delete(int id)
        {
            _questionRepository.Delete(_questionRepository.Get(p => p.Id == id));
        }

        public Question Get(int id)
        {
            return _questionRepository.Get(q => q.Id == id);
        }

        public List<Question> GetAll()
        {
            return _questionRepository.GetAll(null);
        }

        public void Update(Question request)
        {
            _questionRepository.Update(request);
        }
    }
}
