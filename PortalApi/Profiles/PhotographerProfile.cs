﻿using AutoMapper;
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
            CreateMap<Entities.Photographer, Models.PhotographerShortDto>();
        }
    }
}
