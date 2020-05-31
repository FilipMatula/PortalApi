using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Profiles
{
    public class AvailableDesignPhotoProfile : Profile
    {
        public AvailableDesignPhotoProfile()
        {
            CreateMap<Entities.AvailableDesignPhoto, Models.AvailableDesignPhotoThumbnailDto>();
            CreateMap<Entities.AvailableDesignPhoto, Models.AvailableDesignPhotoDto>()
                .ForMember(
                    dest => dest.FormattedDate,
                    opt => opt.MapFrom(src => src.Date.ToString("dd-MM-yyyy HH:mm")));
        }
    }
}
