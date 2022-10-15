using HospitalTestTask.Application.Models;

namespace HospitalTestTask.Application.Interfaces.Repositories
{
    public interface IPatientRepository : IBaseRepository<Patient, Guid>
    {
        public Task<Patient> GetByIdWithAttachments(Guid id,
                CancellationToken ct = default);
    }
}
