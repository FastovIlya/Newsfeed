using AutoMapper;
using NewsFeed.Models;
using NewsFeed.Models.DTO;
using System;

namespace NewsFeed.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<User, RegisterUserDto>();
        }
    }
}

