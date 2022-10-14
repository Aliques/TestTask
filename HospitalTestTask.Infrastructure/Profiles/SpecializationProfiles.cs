using AutoMapper;
using HospitalTestTask.Application.Models;
using HospitalTestTask.Core.DTO.RefsDto;

namespace HospitalTestTask.Infrastructure.Profiles
{
    public class SpecializationProfiles : Profile
    {
        public SpecializationProfiles()
        {
            CreateMap<Specialization, SpecializationDto>();
        }
    }
}
