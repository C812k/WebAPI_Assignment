using WebApplication1.Models.Domain;

namespace WebApplication1.Models.DTO
{
    public class PaginationDataDTO
    {
        public List<PolicyDetailsDTO> PolicyDetails { get; set; } = new List<PolicyDetailsDTO>();
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
    }
}
