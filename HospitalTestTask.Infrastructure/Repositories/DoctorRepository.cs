using HospitalTestTask.Application.Interfaces.Repositories;
using HospitalTestTask.Application.Models;

namespace HospitalTestTask.Infrastructure.Repositories
{
    public class DoctorRepository : BaseRepository<Doctor, long>, IDoctorRepository
    {
        protected readonly RepositoryContext _context;

        public DoctorRepository(RepositoryContext context) : base(context)
        {
            _context = context;
        }
    }
}
