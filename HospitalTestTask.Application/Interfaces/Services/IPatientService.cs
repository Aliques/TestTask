using HospitalTestTask.Core.Application.Requests.Patient;
using HospitalTestTask.Core.Application.Wrapper;
using HospitalTestTask.Core.DTO.Doctor;
using HospitalTestTask.Core.DTO.Patient;

namespace HospitalTestTask.Application.Interfaces.Services
{
    public interface IPatientService
    {
        Task<IResult<PatientDto>> AddAsync(PatientCreationDto patient,
                CancellationToken ct = default);
        Task<IResult<PatientUpdateDto>> UpdateAsync(PatientUpdateDto patient,
                CancellationToken ct = default);
        Task<IResult<PatientUpdateDto>> GetByIdAsync(Guid id,
            CancellationToken ct = default);

        Task<IResult<IPaginatedResult<PatientDto>>> GetAllPaginated(PatientRequest patient,
            CancellationToken ct = default);

        Task<IResult<bool>> DeleteAsync(Guid id, CancellationToken ct = default);
    }
}
