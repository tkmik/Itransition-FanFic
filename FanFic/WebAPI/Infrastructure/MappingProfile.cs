using AutoMapper;
using BusinessLogic.DTO;
using WebAPI.ViewModels;

namespace WebAPI.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CapabilityViewModel, CapabilityDTO>();
            CreateMap<CommentViewModel, CommentDTO>();
            CreateMap<EnumCapabilityViewModel, EnumCapabilityDTO>();
            CreateMap<FanFicViewModel, FanFicDTO>();
            CreateMap<FanFicTopicViewModel, FanFicTopicDTO>();
            CreateMap<LikeViewModel, LikeDTO>();
            CreateMap<TopicViewModel, TopicDTO>();
            CreateMap<UserViewModel, UserDTO>();
            CreateMap<UserCapabilityViewModel, UserCapabilityDTO>();
        }
    }
}
