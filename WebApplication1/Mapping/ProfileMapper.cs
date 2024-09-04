using AutoMapper;
using WebApplication1.Models.Domain;
using WebApplication1.Models.DTO;

namespace WebApplication1.Mapping
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<PolicyDetailsModel, PolicyDetailsDTO>().ReverseMap();
        }
    }
}
