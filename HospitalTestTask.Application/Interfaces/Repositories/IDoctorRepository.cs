using HospitalTestTask.Application.Models;

namespace HospitalTestTask.Application.Interfaces.Repositories
{
    public interface IDoctorRepository : IBaseRepository<Doctor, long>
    {
        public Task<Doctor> GetByIdWithAttachments(long id,
                CancellationToken ct = default);
    }
}
