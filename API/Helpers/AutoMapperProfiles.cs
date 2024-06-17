using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>().ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.Photo.Url));
            CreateMap<Photo, PhotoDto>();
            CreateMap<Company, CompanyDto>();
            CreateMap<Assessment, AssessmentDto>();
            CreateMap<VulnerabilityReport, VulnerabilityReportDto>();
        }
    }
}