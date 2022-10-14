using HospitalTestTask.Core.Application.Wrapper;

namespace HospitalTestTask.Infrastructure.Services
{
    public abstract class BaseService
    {
        protected async Task<IResult<T>> ToResultAsync<T>(Func<Task<T>> func)
               => await Result<T>.ExecuteAsync(func);
        protected async Task<IResult> ToResultAsync(Func<Task> func) => await Result.ExecuteAsync(func);

    }
}
