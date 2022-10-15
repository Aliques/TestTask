using HospitalTestTask.Application.Interfaces.Repositories;
using HospitalTestTask.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalTestTask.Infrastructure.Repositories
{
    public class PatientRepository : BaseRepository<Patient, Guid>, IPatientRepository
    {
        protected readonly RepositoryContext _context;
        public PatientRepository(RepositoryContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Patient> GetByIdWithAttachments(Guid id,
                CancellationToken ct = default)
        {
            return await _context.Patients
                .Include(o => o.DistrictPart)
                .FirstOrDefaultAsync(o => o.Id == id, ct);
        }
    }
}
