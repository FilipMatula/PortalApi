using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Profiles
{
    public class PhotographerPhotoProfile : Profile
    {
        public PhotographerPhotoProfile()
        {
            CreateMap<Entities.PhotographerPhoto, Models.PhotographerPhotoThumbnailDto>();
            CreateMap<Entities.PhotographerPhoto, Models.PhotographerPhotoDto>()
                .ForMember(
                    dest => dest.FormattedDate,
                    opt => opt.MapFrom(src => src.Date.ToString("dd-MM-yyyy HH:mm")));
            CreateMap<Models.PhotographerPhotoForCreationDto, Entities.PhotographerPhoto>();
        }
    }
}
