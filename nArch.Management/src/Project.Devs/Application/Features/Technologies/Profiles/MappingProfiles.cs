using Application.Features.Technologies.Dtos;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Technologies.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Technology, TechnologyListDto>()
                .ForMember(c => c.ProgrammingLanguageName, opt => opt.MapFrom(c => c.ProgrammingLanguage.Name))
                .ReverseMap();
            CreateMap<IPaginate<Technology>, TechnologyListDto>().ReverseMap();
        }
    }
}
