using AutoMapper;
using waw_employer_service.Domain.Model;
using waw_employer_service.Resources;

namespace waw_employer_service.Mapping
{
    public static class CompanyResourceToModelProfile
    {
        public static void Register(IProfileExpression profile)
        {
            profile.CreateMap<CompanyRequest, Company>();
        }
    }
}
