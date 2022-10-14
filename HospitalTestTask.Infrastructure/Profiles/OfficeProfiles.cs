using AutoMapper;
using HospitalTestTask.Application.Models;
using HospitalTestTask.Core.DTO.RefsDto;

namespace HospitalTestTask.Infrastructure.Profiles
{
    public class OfficeProfiles : Profile
    {
        public OfficeProfiles()
        {
            CreateMap<Office, OfficeDto>();
        }
    }
}
