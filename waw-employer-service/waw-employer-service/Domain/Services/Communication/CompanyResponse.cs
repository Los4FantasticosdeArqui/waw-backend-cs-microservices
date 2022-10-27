using waw_employer_service.Domain.Model;

namespace waw_employer_service.Domain.Services.Communication
{
    public class CompanyResponse : BaseResponse<Company>
    {
        public CompanyResponse(string message) : base(message) { }
        public CompanyResponse(Company resource) : base(resource) { }
    }
}
