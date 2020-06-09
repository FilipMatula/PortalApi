using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Entities.User, Models.UserDto>();
            CreateMap<Entities.User, Models.UserShortDto>();
            CreateMap<Models.UserRegisterDto, Entities.User> ();
            CreateMap<Models.UserUpdateDto, Entities.User>();
        }
    }
}