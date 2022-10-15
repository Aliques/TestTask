using AutoMapper;
using HospitalTestTask.Application.Interfaces.Repositories;
using HospitalTestTask.Application.Interfaces.Services;
using HospitalTestTask.Application.Models;
using HospitalTestTask.Core.Application.Extensions;
using HospitalTestTask.Core.Application.Requests.Patient;
using HospitalTestTask.Core.Application.Wrapper;
using HospitalTestTask.Core.DTO.Doctor;
using HospitalTestTask.Core.DTO.Patient;
using System.Numerics;


namespace HospitalTestTask.Infrastructure.Services
{
    public class PatientService : BaseService, IPatientService
    {
        private readonly IPatientRepository _repository;
        private readonly IMapper _mapper;

        public PatientService(IPatientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IResult<PatientDto>> AddAsync(PatientCreationDto patient, CancellationToken ct = default)
        {
            return await ToResultAsync(async () =>
            {
                var entity = _mapper.Map<Patient>(patient);
                var createdEntity = await _repository.AddAsync(entity, ct);
                var createdPatient = await _repository.GetByIdWithAttachments(createdEntity.Id, ct);
                var outputEntity = _mapper.Map<PatientDto>(createdPatient);
                return outputEntity;
            });
        }

        public async Task<IResult<bool>> DeleteAsync(Guid id, CancellationToken ct = default)
        {
            return await ToResultAsync(async () =>
            {
                var deleted = await _repository.DeleteAsync(id, ct);
                return deleted;
            });
        }

        public async Task<IResult<IPaginatedResult<PatientDto>>> GetAllPaginated(PatientRequest patientRequest, CancellationToken ct = default)
        {
            return await ToResultAsync(async () =>
            {
                var patients = await _repository.GetAllPaginated(patientRequest, true, ct);
                var patientsDto = _mapper.Map<List<PatientDto>>(patients);
                return patientsDto.ToPaginatedList(patientRequest);
            });
        }

        public async Task<IResult<PatientUpdateDto>> GetByIdAsync(Guid id, CancellationToken ct = default)
        {
            return await ToResultAsync(async () =>
            {
                var patient = await _repository.GetByIdAsync(id, ct);
                var patientDto = _mapper.Map<PatientUpdateDto>(patient);
                return patientDto;
            });
        }

        public async Task<IResult<PatientUpdateDto>> UpdateAsync(PatientUpdateDto patient, CancellationToken ct = default)
        {
            return await ToResultAsync(async () =>
            {
                var editablePatient = _mapper.Map<Patient>(patient);
                await _repository.UpdateAsync(editablePatient, ct);
                var doctorDto = _mapper.Map<PatientUpdateDto>(patient);
                return doctorDto;
            });
        }
    }
}
