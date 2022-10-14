using HospitalTestTask.Core.Application.Requests;
using HospitalTestTask.Core.Application.Wrapper;
using HospitalTestTask.Domain.Entities;

namespace HospitalTestTask.Application.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity, TId> //where TEntity : Entity<TId>
    {
        Task<TEntity> AddAsync(TEntity entity,
                CancellationToken ct = default);
        Task<bool> UpdateAsync(TEntity entity,
                CancellationToken ct);
        Task<TEntity?> GetByIdAsync(TId id,
            CancellationToken ct);

        Task<List<TEntity>> GetAllPaginated(PagedRequest request,
            CancellationToken ct = default);

    }
}
