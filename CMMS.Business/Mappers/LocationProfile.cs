﻿using AutoMapper;
using CMMS.Domain.Entities;
using CMMS.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMMS.Business.Mappers
{

    public class LocationProfile : Profile
    {
        public LocationProfile()
        {
            // Location entity'sinden LocationDto'ya ve tersi dönüşüm
            CreateMap<Location, LocationDto>().ReverseMap();
        }
    }
}
