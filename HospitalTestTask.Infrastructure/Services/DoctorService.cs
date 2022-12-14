using AutoMapper;
using HospitalTestTask.Application.Interfaces.Repositories;
using HospitalTestTask.Application.Interfaces.Services;
using HospitalTestTask.Application.Models;
using HospitalTestTask.Core.Application.Extensions;
using HospitalTestTask.Core.Application.Requests.Doctor;
using HospitalTestTask.Core.Application.Wrapper;
using HospitalTestTask.Core.DTO.Doctor;
using System.Numerics;

namespace HospitalTestTask.Infrastructure.Services
{
    public class DoctorService : BaseService, IDoctorService
    {
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;

        public DoctorService(IDoctorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IResult<DoctorDto>> AddAsync(DoctorCreationDto doctor, CancellationToken ct = default)
        {
            return await ToResultAsync(async () =>
            {
                var entity = _mapper.Map<Doctor>(doctor);
                var createdEntity = await _repository.AddAsync(entity, ct);
                var createdDoctor = await _repository.GetByIdWithAttachments(createdEntity.Id, ct);
                var outputEntity = _mapper.Map<DoctorDto>(createdDoctor);
                return outputEntity;
            });
        }

        public async Task<IResult<IPaginatedResult<DoctorDto>>> GetAllPaginated(DoctorRequest request, CancellationToken ct = default)
        {
            return await ToResultAsync(async () =>
            {
                var doctors = await _repository.GetAllPaginated(request, true, ct);
                var doctorsDto = _mapper.Map<List<DoctorDto>>(doctors);
                return doctorsDto.ToPaginatedList(request);
            });
        }

        public async Task<IResult<DoctorUpdateDto>> GetByIdAsync(long id, CancellationToken ct = default)
        {
            return await ToResultAsync(async () =>
            {
                var doctor = await _repository.GetByIdAsync(id, ct);
                var doctorDto = _mapper.Map<DoctorUpdateDto>(doctor);
                return doctorDto;
            });
        }

        public async Task<IResult<DoctorUpdateDto>> UpdateAsync(DoctorUpdateDto doctor, CancellationToken ct = default )
        {
            return await ToResultAsync(async () =>
            {
                var editableDoctor = _mapper.Map<Doctor>(doctor);
                await _repository.UpdateAsync(editableDoctor, ct);
                var doctorDto = _mapper.Map<DoctorUpdateDto>(doctor);
                return doctorDto;
            });
        }

        public async Task<IResult<bool>> DeleteAsync(long id, CancellationToken ct = default)
        {
            return await ToResultAsync(async () =>
            {
                var deleted = await _repository.DeleteAsync(id, ct);
                return deleted;
            });
        }
    }
}
