using AutoMapper;

namespace MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company,CompanyDTO>
        }
    }
}