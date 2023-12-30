using AutoMapper;
using Entities.Concrete;
using Entities.Concrete.Dto.Request.Category;
using Entities.Concrete.Dto.Request.Question;
using Entities.Concrete.Dto.Response;

namespace WebApi.utils
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Question Mappers
            CreateMap<CreateQuestionDto, Question>();
            CreateMap<UpdateQuestionDto, Question>();
            CreateMap<Question, QuestionResponse>();

            CreateMap<CreateCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, Category>();
            CreateMap<Category, CategoryResponse>();
        }
    }
}
