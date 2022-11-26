using AutoMapper;

namespace waw_employer_service.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CompanyResourceToModelProfile.Register(this);
        }
    }
}
