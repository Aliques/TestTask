using AutoMapper;
using HospitalTestTask.Application.Models;
using HospitalTestTask.Core.DTO.Doctor;
using HospitalTestTask.Core.DTO.Patient;

namespace HospitalTestTask.Infrastructure.Profiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<Patient, PatientDto>();
            CreateMap<Patient, PatientUpdateDto>();
            CreateMap<PatientUpdateDto, Patient>();
            CreateMap<PatientCreationDto, Patient>();
        }
    }
}
