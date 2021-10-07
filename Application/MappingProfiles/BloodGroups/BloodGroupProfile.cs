using Application.Commands.BloodGroups;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.MappingProfiles.BloodGroups
{
    public class BloodGroupProfile : Profile
    {
        public BloodGroupProfile()
        {
            CreateMap<BloodGroup, BloodGroupDto>();

            CreateMap<CreateBloodGroupCommand, BloodGroup>();
        }
    }
}
