using AutoMapper;
using HospitalTestTask.Application.Models;
using HospitalTestTask.Core.DTO.Doctor;

namespace HospitalTestTask.Infrastructure.Profiles
{
    public class DoctorProfiles : Profile
    {
        public DoctorProfiles()
        {
            CreateMap<Doctor, DoctorDto>();
            CreateMap<Doctor, DoctorUpdateDto>();
            CreateMap<DoctorUpdateDto, Doctor>();
            CreateMap<DoctorCreationDto, Doctor>();
        }
    }
}
