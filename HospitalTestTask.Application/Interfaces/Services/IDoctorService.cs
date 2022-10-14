using HospitalTestTask.Core.Application.Requests;
using HospitalTestTask.Core.Application.Requests.Doctor;
using HospitalTestTask.Core.Application.Wrapper;
using HospitalTestTask.Core.DTO.Doctor;
using System.Security.Cryptography;

namespace HospitalTestTask.Application.Interfaces.Services
{
    public interface IDoctorService
    {
        Task<IResult<DoctorDto>> AddAsync(DoctorCreationDto doctor,
                CancellationToken ct = default);
        Task<IResult> UpdateAsync(DoctorUpdateDto doctor,
                CancellationToken ct);
        Task<IResult<DoctorUpdateDto>> GetByIdAsync(long id,
            CancellationToken ct);

        Task<IResult<IPaginatedResult<DoctorDto>>> GetAllPaginated(DoctorRequest request,
            CancellationToken ct = default);
    }
}
