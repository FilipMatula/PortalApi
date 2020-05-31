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
            CreateMap<Entities.Piercing, Models.PunctureThumbnailDto>();
            CreateMap<Entities.Piercing, Models.PunctureDto>()
                .ForMember(
                    dest => dest.FormattedDate,
                    opt => opt.MapFrom(src => src.Date.ToString("dd-MM-yyyy HH:mm")));
        }
    }
}
