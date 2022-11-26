using AutoMapper;

namespace waw_employer_service.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CompanyModelToResourceProfile.Register(this);
        }
    }
}
