using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Entities = ApplicationCore.Entities;
using Dtos = ApplicationCore.DTOs;
namespace Infrastructure
{
    public class AutoMapperProfiles
    {
        public class TermProfile : Profile
        {
            public TermProfile()
            {
                CreateMap<Entities.Term, Dtos.Term>();
                CreateMap<Dtos.InputTerm, Entities.Term>();
            }
        }
    }
}
