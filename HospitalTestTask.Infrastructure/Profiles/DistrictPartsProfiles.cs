
using AutoMapper;
using HospitalTestTask.Application.Models;
using HospitalTestTask.Core.DTO.RefsDto;

namespace HospitalTestTask.Infrastructure.Profiles
{
    public class DistrictPartsProfiles : Profile
    {
        public DistrictPartsProfiles()
        {
            CreateMap<DistrictPart, DistrictPartDto>();
        }
    }
}
