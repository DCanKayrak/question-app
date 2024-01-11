using AutoMapper;
using Core.Entity.Concrete;
using Entities.Concrete;
using Entities.Concrete.Dto.Request;
using Entities.Concrete.Dto.Request.Answer;
using Entities.Concrete.Dto.Request.Category;
using Entities.Concrete.Dto.Request.Question;
using Entities.Concrete.Dto.Response;
using Entities.Concrete.Models;

namespace WebApi.utils
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Question Mappers
            CreateMap<CreateAnswerDto, Answer>();
            CreateMap<Answer, CreateAnswerDto>();
            CreateMap<UpdateAnswerDto, Answer>();
            CreateMap<Answer, AnswerResponse>();
            CreateMap<AnswerResponse, Answer>();

            CreateMap<CreateQuestionDto, Question>();
            CreateMap<UpdateQuestionDto, Question>();
            CreateMap<Question, QuestionResponse>();

            CreateMap<CreateCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, Category>();
            CreateMap<Category, CategoryResponse>();

            CreateMap<User,UserResponse>();
            CreateMap<UserResponse, User>();

            CreateMap<CreateAnswerImgDto, AnswerImage> ();
            CreateMap<AnswerImage,AnswerImageResponse>();
        }
    }
}
