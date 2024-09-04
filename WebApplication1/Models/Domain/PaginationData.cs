namespace WebApplication1.Models.Domain
{
    public class PaginationData
    {
        public List<PolicyDetailsModel> PolicyDetails { get; set; } = new List<PolicyDetailsModel>();
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
    }
}
