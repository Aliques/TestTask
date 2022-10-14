namespace HospitalTestTask.Core.Application.Wrapper
{
    public class PaginatedResult<T> : Result, IPaginatedResult<T>
    {
        public PaginatedResult(List<T> data)
        {
            Data = data;
        }

        public List<T> Data { get; set; }

        internal PaginatedResult(bool succeeded, List<T> data = default, List<string> messages = null, int count = 0, int page = 1, int pageSize = 10)
        {
            Data = data;
            CurrentPage = page;
            Succeeded = succeeded;
            PageSize = pageSize;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            TotalCount = count;
        }

        public static PaginatedResult<T> Fail(params string[] messages)
        {
            return new PaginatedResult<T>(false, default, messages.ToList());
        }

        public static PaginatedResult<T> Failure(List<string> messages)
        {
            return new PaginatedResult<T>(false, default, messages);
        }

        public static PaginatedResult<T> Success(List<T> data, int count, int page, int pageSize)
        {
            return new PaginatedResult<T>(true, data, null, count, page, pageSize);
        }

        public static PaginatedResult<T> Success(List<T> data)
        {
            var result = new PaginatedResult<T>(data);
            result.Succeeded = true;
            result.TotalCount = result.Data.Count;
            result.CurrentPage = 1;
            result.PageSize = result.TotalCount;
            result.TotalPages = 1;
            return result;
        }

        public static async Task<IPaginatedResult<T>> ExecuteAsync(Func<Task<IPaginatedResult<T>>> func, Action<string> logFunc)
        {
            try
            {
                return await func();
            }
            catch (Exception e)
            {
                if (logFunc != null)
                    logFunc($"{e}");
                return Fail(e.Message);
            }
        }

        public static async Task<IPaginatedResult<T>> ExecuteAsync(Func<Task<IPaginatedResult<T>>> func)
        {
            try
            {
                return await func();
            }
            catch (Exception e)
            {
                return Fail(e.Message);
            }
        }

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public int TotalCount { get; set; }
        public int PageSize { get; set; }

        public bool HasPreviousPage => CurrentPage > 1;

        public bool HasNextPage => CurrentPage < TotalPages;

        public PaginatedResult<TData> Clone<TData>(List<TData> newData)
        {
            var result = new PaginatedResult<TData>(Succeeded, newData);
            result.PageSize = PageSize;
            result.TotalCount = TotalCount;
            result.TotalPages = TotalPages;
            result.CurrentPage = CurrentPage;
            result.CurrentPage = CurrentPage;
            return result;
        }
    }
}
