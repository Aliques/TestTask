using HospitalTestTask.Core.Application.Requests;
using HospitalTestTask.Core.Application.Wrapper;

namespace HospitalTestTask.Core.Application.Extensions
{
    public static class ListExtensions
    {
        public static PaginatedResult<T> ToPaginatedList<T>(this List<T> source, int pageNumber, int pageSize)
            where T : class
        {
            if (source == null) throw new ArgumentNullException();
            pageNumber = pageNumber == 0 ? 1 : pageNumber;
            pageSize = pageSize == 0 ? 10 : pageSize;
            int count = source.Count;
            pageNumber = pageNumber <= 0 ? 1 : pageNumber;
            List<T> items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return PaginatedResult<T>.Success(items, count, pageNumber, pageSize);
        }

        public static PaginatedResult<T> ToPaginatedList<T>(this List<T> source, PagedRequest request)
            where T : class
        {
            if (request.PageNumber.HasValue && request.PageSize.HasValue)
                return source.ToPaginatedList(request.PageNumber.Value, request.PageSize.Value);
            return PaginatedResult<T>.Success(source);
        }

        public static List<T> OrderBy<T>(this List<T> source, PagedRequest request)
            where T : class
        {
            var sortProperty = request.SortField is null ? null : typeof(T).GetProperty(request.SortField);
            if (sortProperty == null)
                return source;
            if (request.SortDescending)
                return source.OrderByDescending(i => sortProperty.GetValue(i)).ToList();
            return source.OrderBy(i => sortProperty.GetValue(i)).ToList();
        }

    }
}
