using HospitalTestTask.Application.Interfaces.Repositories;
using HospitalTestTask.Application.Models;
using Microsoft.EntityFrameworkCore;
namespace HospitalTestTask.Infrastructure.Repositories
{
    public class DoctorRepository : BaseRepository<Doctor, long>, IDoctorRepository
    {
        protected readonly RepositoryContext _context;

        public DoctorRepository(RepositoryContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Doctor> GetByIdWithAttachments(long id,
                CancellationToken ct = default)
        {
            return await _context.Doctors
                .Include(o=>o.Office)
                .Include(o=>o.DistrictPart)
                .Include(o=>o.Specialization)
                .FirstOrDefaultAsync(o=>o.Id==id, ct);
        }
    }
}
