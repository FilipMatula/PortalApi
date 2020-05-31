using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Profiles
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<Entities.Model, Models.ModelThumbnailDto>();
            CreateMap<Entities.Model, Models.ModelDto>()
                .ForMember(
                    dest => dest.FormattedDate,
                    opt => opt.MapFrom(src => src.Date.ToString("dd-MM-yyyy HH:mm")));
        }
    }
}
