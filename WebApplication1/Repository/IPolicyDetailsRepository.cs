using WebApplication1.Models.Domain;

namespace WebApplication1.Repository
{
    public interface IPolicyDetailsRepository
    {
        Task<PaginationData> GetPolicyDetailsAsync(bool isAscending, string? sortBy = null, int pageNumber = 1, int pageSize = 10);
        Task<PaginationData> SearchPoliciesAsync(bool isAscending, string searchWord, string? sortBy = null, int pageNumber = 1, int pageSize = 10);
    }
}
