using Microsoft.EntityFrameworkCore;
using System.Globalization;
using WebApplication1.Data;
using WebApplication1.Models.Domain;
using WebApplication1.Models.DTO;

namespace WebApplication1.Repository
{
    public class PolicyDetailsRepository : IPolicyDetailsRepository
    {
        private readonly PolicyDetailsDBContext _policyDetailsDBContext;

        public PolicyDetailsRepository(PolicyDetailsDBContext policyDetailsDBContext)
        {
            _policyDetailsDBContext = policyDetailsDBContext;
        }

        public async Task<PaginationData> GetPolicyDetailsAsync(bool isAscending, string? sortBy = null, int pageNumber = 1, int pageSize = 10)
        {
            var policyDetails = _policyDetailsDBContext.policyDetails.AsQueryable();

            policyDetails = isAscending ? policyDetails.OrderBy(x => x.CreationDate) : policyDetails.OrderByDescending(x => x.CreationDate);

            var totalRecords = await policyDetails.CountAsync();
            var skipResults = (pageNumber - 1) * pageSize;
            var pagedPolicyDetails = await policyDetails.Skip(skipResults).Take(pageSize).ToListAsync();
            var totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            var paginationData = new PaginationData
            {
                PolicyDetails = pagedPolicyDetails,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalRecords = totalRecords,
                TotalPages = totalPages
            };

            return paginationData;
        }

        public async Task<PaginationData> SearchPoliciesAsync(bool isAscending, string searchWord, string? sortBy = null, int pageNumber = 1, int pageSize = 10)
        {
            var allPolicies = _policyDetailsDBContext.policyDetails.AsQueryable();
            var policies = from policy in allPolicies
                           where (policy.PolicyOwner.Contains(searchWord)
                                       || policy.CarMake.Contains(searchWord))
                                select policy;

            var totalRecords = await policies.CountAsync();
            var skipResults = (pageNumber - 1) * pageSize;
            var pagedPolicyDetails = await policies.Skip(skipResults).Take(pageSize).ToListAsync();
            var totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            var paginationData = new PaginationData
            {
                PolicyDetails = pagedPolicyDetails,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalRecords = totalRecords,
                TotalPages = totalPages
            };

            return paginationData;
        }
    }
}
