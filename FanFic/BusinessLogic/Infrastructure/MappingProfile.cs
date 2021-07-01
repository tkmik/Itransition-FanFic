using AutoMapper;
using BusinessLogic.DTO;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CapabilityDTO, Capability>();
            CreateMap<CommentDTO, Comment>();
            CreateMap<EnumCapabilityDTO, EnumCapability>();
            CreateMap<FanFicDTO, FanFic>();
            CreateMap<FanFicTopicDTO, FanFicTopic>();
            CreateMap<LikeDTO, Like>();
            CreateMap<TopicDTO, Topic>();
            CreateMap<UserDTO, User>();
            CreateMap<UserCapabilityDTO, UserCapability>();
        }
    }
}
