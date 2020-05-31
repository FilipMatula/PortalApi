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
            CreateMap<Entities.Photographer, Models.PhotographerDto>()
                .ForMember(
                    dest => dest.FormattedDate,
                    opt => opt.MapFrom(src => src.Date.ToString("dd-MM-yyyy HH:mm")));
        }
    }
}
