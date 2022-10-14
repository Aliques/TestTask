
namespace HospitalTestTask.Core.Application.Requests
{
    public class PagedRequest
    {
        public int? PageSize { get; set; }
        public int? PageNumber { get; set; }
        public string? SortField { get; set; }
        public bool SortDescending { get; set; }
    }
}
