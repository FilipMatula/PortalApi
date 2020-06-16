using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Profiles
{
    public class ProfilesPropertiesProfile : Profile
    {
        public ProfilesPropertiesProfile()
        {
            CreateMap<ProfilesProperties.BodyDecorations, Models.BodyDecorationsDto>().ReverseMap();
        }
    }
}
