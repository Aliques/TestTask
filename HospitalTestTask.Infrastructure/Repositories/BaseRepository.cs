
using HospitalTestTask.Core.Application.Wrapper;
using HospitalTestTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using HospitalTestTask.Core.Application.Extensions;
using HospitalTestTask.Application.Interfaces.Repositories;
using System.Security.Cryptography;
using HospitalTestTask.Core.Application.Requests;
using Microsoft.VisualBasic;

namespace HospitalTestTask.Infrastructure.Repositories
{
    public class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId> where TEntity : Entity<TId>
    {
        protected readonly RepositoryContext _context;
        public BaseRepository(RepositoryContext context)
        {
            _context = context;
        }

        public async Task<TEntity> AddAsync(TEntity entity,
                CancellationToken ct = default)
        {
            var createdEntity = _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync(ct);
            return createdEntity.Entity;
        }

        public async Task<bool> UpdateAsync(TEntity entity,
                CancellationToken ct)
        {
            _context.Entry(entity).CurrentValues.SetValues(entity);
            return await _context.SaveChangesAsync(ct) >= 1;
        }

        public async Task<TEntity?> GetByIdAsync(TId id,
            CancellationToken ct)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetAllPaginated(PagedRequest request, 
            CancellationToken ct = default)
        {
            var set = _context.Set<TEntity>().AsNoTracking();
            var source = await set.ToListAsync(ct);
            return source.OrderBy(request);
        }

        public async Task<bool> DeleteAsync(TId id, CancellationToken ct = default)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            _context.Set<TEntity>().Remove(entity);
           return  await _context.SaveChangesAsync(ct) >=1 ;
        }
    }
}
