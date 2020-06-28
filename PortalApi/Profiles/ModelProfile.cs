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
            CreateMap<Entities.Model, Models.ModelDto>();
            //.ForPath(
            //    dest => dest.User.RegistrationDate,
            //    opt => opt.MapFrom(src => src.User.RegistrationDate.ToString("dd/MM/yyyy HH:mm")));
            CreateMap<Models.ModelForCreationDto, Entities.Model>();
        }
    }
}
