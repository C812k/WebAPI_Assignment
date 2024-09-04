using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using WebApplication1.Models.Domain;
using WebApplication1.Models.DTO;
using WebApplication1.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : ControllerBase
    {
        private readonly IPolicyDetailsRepository _policyDetailsRepositor;
        private readonly IMapper _mapper;

        public PolicyController(IPolicyDetailsRepository policyDetailsRepositor, IMapper mapper)
        {
            _policyDetailsRepositor = policyDetailsRepositor;
            _mapper = mapper;
        }

        [HttpGet("get-policies")]

        public async Task<IActionResult> GetAllPolicyDetails([FromQuery] string? sortBy, [FromQuery] bool? isAscending,
            [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var paginationData = await _policyDetailsRepositor.GetPolicyDetailsAsync(isAscending ?? true, sortBy, pageNumber, pageSize);

            var policyDetailsDTO = _mapper.Map<List<PolicyDetailsDTO>>(paginationData.PolicyDetails);

            var response = new PaginationDataDTO
            {
                PolicyDetails = policyDetailsDTO,
                PageNumber = paginationData.PageNumber,
                PageSize = paginationData.PageSize,
                TotalPages = paginationData.TotalPages,
                TotalRecords = paginationData.TotalRecords
            };

            return Ok(response);
        }

        [HttpGet("search-policy")]
        public async Task<IActionResult> SearchPolicies([FromQuery] string? sortBy, [FromQuery] bool? isAscending, [FromQuery] string searchWord,
            [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var paginationData = await _policyDetailsRepositor.SearchPoliciesAsync(isAscending?? true,searchWord,sortBy,pageNumber, pageSize);
            var policyDetailsDTO = _mapper.Map<List<PolicyDetailsDTO>>(paginationData.PolicyDetails);

            var response = new PaginationDataDTO
            {
                PolicyDetails = policyDetailsDTO,
                PageNumber = paginationData.PageNumber,
                PageSize = paginationData.PageSize,
                TotalPages = paginationData.TotalPages,
                TotalRecords = paginationData.TotalRecords
            };

            return Ok(response);
        }
    }
}
