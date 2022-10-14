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
        Task<IResult<DoctorUpdateDto>> UpdateAsync(DoctorUpdateDto doctor,
                CancellationToken ct = default);
        Task<IResult<DoctorUpdateDto>> GetByIdAsync(long id,
            CancellationToken ct = default);

        Task<IResult<IPaginatedResult<DoctorDto>>> GetAllPaginated(DoctorRequest request,
            CancellationToken ct = default);

        Task<IResult<bool>> DeleteAsync(long id, CancellationToken ct = default);
    }
}
