using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Domain;
using WebApplication1.Models.Domain.Enums;

namespace WebApplication1.Data
{
    public class PolicyDetailsDBContext : DbContext
    {
        public PolicyDetailsDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<PolicyDetailsModel> policyDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var policyDetails = new List<PolicyDetailsModel>()
            {
                new PolicyDetailsModel()
                {
                    QuotationNumber = Guid.NewGuid(),
                    PolicyOwner = "Charbel",
                    CarMake = "Mercedes",
                    CarYearOfMake = "2023",
                    QuotationStatus = QuotationStatus.Purchased,
                    CreationDate = DateTime.Now,
                },
                new PolicyDetailsModel()
                {
                    QuotationNumber = Guid.NewGuid(),
                    PolicyOwner = "Elie",
                    CarMake = "Camaro",
                    CarYearOfMake = "2023",
                    QuotationStatus = QuotationStatus.Purchased,
                    CreationDate = DateTime.Now,
                },
                new PolicyDetailsModel()
                {
                    QuotationNumber = Guid.NewGuid(),
                    PolicyOwner = "Etienne",
                    CarMake = "Golf",
                    CarYearOfMake = "2023",
                    QuotationStatus = QuotationStatus.Draft,
                    CreationDate = DateTime.Now,
                },
                new PolicyDetailsModel()
                {
                    QuotationNumber = Guid.NewGuid(),
                    PolicyOwner = "Bob",
                    CarMake = "bmw",
                    CarYearOfMake = "2020",
                    QuotationStatus = QuotationStatus.Draft,
                    CreationDate = DateTime.Now,
                },
                new PolicyDetailsModel()
                {
                    QuotationNumber = Guid.NewGuid(),
                    PolicyOwner = "Abdo",
                    CarMake = "Kia",
                    CarYearOfMake = "2015",
                    QuotationStatus = QuotationStatus.Draft,
                    CreationDate = DateTime.Now,
                },
                new PolicyDetailsModel()
                {
                    QuotationNumber = Guid.NewGuid(),
                    PolicyOwner = "Roula",
                    CarMake = "suzuki",
                    CarYearOfMake = "2028",
                    QuotationStatus = QuotationStatus.Draft,
                    CreationDate = DateTime.Now,
                },
                new PolicyDetailsModel()
                {
                    QuotationNumber = Guid.NewGuid(),
                    PolicyOwner = "Thierry",
                    CarMake = "Mercedes",
                    CarYearOfMake = "2012",
                    QuotationStatus = QuotationStatus.Draft,
                    CreationDate = DateTime.Now,
                },
                new PolicyDetailsModel()
                {
                    QuotationNumber = Guid.NewGuid(),
                    PolicyOwner = "Rita",
                    CarMake = "Range",
                    CarYearOfMake = "2023",
                    QuotationStatus = QuotationStatus.Draft,
                    CreationDate = DateTime.Now,
                },
                new PolicyDetailsModel()
                {
                    QuotationNumber = Guid.NewGuid(),
                    PolicyOwner = "James",
                    CarMake = "jeep",
                    CarYearOfMake = "2017",
                    QuotationStatus = QuotationStatus.Draft,
                    CreationDate = DateTime.Now,
                },
                new PolicyDetailsModel()
                {
                    QuotationNumber = Guid.NewGuid(),
                    PolicyOwner = "Roudy",
                    CarMake = "BMW",
                    CarYearOfMake = "2019",
                    QuotationStatus = QuotationStatus.Draft,
                    CreationDate = DateTime.Now,
                },
                new PolicyDetailsModel()
                {
                    QuotationNumber = Guid.NewGuid(),
                    PolicyOwner = "Fredy",
                    CarMake = "Lexus",
                    CarYearOfMake = "2016",
                    QuotationStatus = QuotationStatus.Draft,
                    CreationDate = DateTime.Now,
                },
                new PolicyDetailsModel()
                {
                    QuotationNumber = Guid.NewGuid(),
                    PolicyOwner = "Miguel",
                    CarMake = "Nissan",
                    CarYearOfMake = "2023",
                    QuotationStatus = QuotationStatus.Draft,
                    CreationDate = DateTime.Now,
                }
            };

            modelBuilder.Entity<PolicyDetailsModel>().HasData(policyDetails);
        }
    }
}
