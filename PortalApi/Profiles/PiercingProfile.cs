using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Profiles
{
    public class PiercingProfile : Profile
    {
        public PiercingProfile()
        {
            CreateMap<Entities.Piercing, Models.PiercingThumbNailDto>();
            CreateMap<Entities.Piercing, Models.PiercingDto>()
                .ForMember(
                    dest => dest.FormattedDate,
                    opt => opt.MapFrom(src => src.Date.ToString("dd-MM-yyyy HH:mm")));
        }
    }
}
