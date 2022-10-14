using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTestTask.Core.Application.Wrapper
{
    public interface IPaginatedResult<T> : IResult
    {
        List<T> Data { get; set; }
        int CurrentPage { get; set; }
        int TotalPages { get; set; }
        int TotalCount { get; set; }
        int PageSize { get; set; }
        bool HasPreviousPage { get; }
        bool HasNextPage { get; }
    }
}
