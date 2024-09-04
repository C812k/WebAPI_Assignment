using System.ComponentModel.DataAnnotations;
using WebApplication1.Models.Domain.Enums;

namespace WebApplication1.Models.Domain
{
    public class PolicyDetailsModel
    {
        [Key]
        public Guid QuotationNumber { get; set; }
        public string? PolicyOwner { get; set; }
        public string? CarMake { get; set; }
        public string? CarYearOfMake { get; set; }
        public QuotationStatus QuotationStatus { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
