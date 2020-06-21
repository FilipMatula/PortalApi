using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Profiles
{
    public class TattooerProfile : Profile
    {
        public TattooerProfile()
        {
            CreateMap<Entities.Tattooer, Models.TattooerThumbnailDto>();
            CreateMap<Entities.Tattooer, Models.TattooerDto>();
            // TODO : map from parent 
            /** instead of .ForMember() 
             *  use        .ForPath()   but it crush reponse of api
             */
        }
    }
}
