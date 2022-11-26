using AutoMapper;
using waw_employer_service.Domain.Model;
using waw_employer_service.Resources;

namespace waw_employer_service.Mapping
{
    public static class CompanyModelToResourceProfile
    {
        public static void Register(IProfileExpression profile)
        {
            profile.CreateMap<Company, CompanyResource>();
        }
    }
}
