using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Profiles
{
    public class PhotographerProfile : Profile
    {
        public PhotographerProfile()
        {
            CreateMap<Entities.Photographer, Models.PhotographerThumbnailDto>();
            CreateMap<Entities.Photographer, Models.PhotographerDto>();
            // TODO map child property ??
            //.ForPath(
            //    dest => dest.User.RegistrationDate,
            //    opt => opt.MapFrom(src => src.User.RegistrationDate.ToString("dd-MM-yyyy HH:mm")));
        }
    }
}
