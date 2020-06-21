using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Profiles
{
    public class PiercerProfile : Profile
    {
        public PiercerProfile()
        {
            CreateMap<Entities.Piercer, Models.PiercerThumbnailDto>();
            CreateMap<Entities.Piercer, Models.PiercerDto>();
            // TODO map child property ??
                //.ForPath(
                //    dest => dest.User.RegistrationDate,
                //    opt => opt.MapFrom(src => src.User.RegistrationDate.ToString("dd-MM-yyyy HH:mm")));
        }
    }
}
