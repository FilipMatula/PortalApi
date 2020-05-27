using AutoMapper;

namespace PortalApi.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Entities.Person, Models.PersonDto>();
        }
    }
}
