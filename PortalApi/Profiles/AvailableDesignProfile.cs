using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Profiles
{
    public class AvailableDesignProfile : Profile
    {
        public AvailableDesignProfile()
        {
            CreateMap<Entities.AvailableDesign, Models.AvailableDesignThumbnailDto>();
            CreateMap<Entities.AvailableDesign, Models.AvailableDesignDto>()
                .ForMember(
                    dest => dest.FormattedDate,
                    opt => opt.MapFrom(src => src.Date.ToString("dd-MM-yyyy HH:mm")));
        }
    }
}
