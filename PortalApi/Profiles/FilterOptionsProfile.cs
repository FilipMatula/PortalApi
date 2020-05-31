using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalApi.Profiles
{
    public class FilterOptionsProfile : Profile
    {
        public FilterOptionsProfile()
        {
            //CreateMap<KeyValuePair<string, TestClass>, KeyValuePair<string, TestClassDto>>()
            //    .ConstructUsing(x => new KeyValuePair<string, TestClassDto>(x.Key,
            //                                                       x.Value.MapTo<TestClassDto>()));
            CreateMap<KeyValuePair<string, int>, Models.FilterOptionDto>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.Value))
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.Key));
        }
    }
}
