using AutoMapper;
using Entities.Concrete;
using Entities.Concrete.Dto.Request.Question;

namespace WebApi.utils
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Question Mappers
            CreateMap<CreateQuestionDto, Question>();
            CreateMap<UpdateQuestionDto, Question>();
        }
    }
}
