using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Profiles
{
    public class ModelPhotoProfile : Profile
    {
        public ModelPhotoProfile()
        {
            CreateMap<Entities.ModelPhoto, Models.ModelPhotoThumbnailDto>();
            CreateMap<Entities.ModelPhoto, Models.ModelPhotoDto>()
                .ForMember(
                    dest => dest.FormattedDate,
                    opt => opt.MapFrom(src => src.Date.ToString("dd-MM-yyyy HH:mm")));
            CreateMap<Models.ModelPhotoForCreationDto, Entities.ModelPhoto>();
        }
    }
}
