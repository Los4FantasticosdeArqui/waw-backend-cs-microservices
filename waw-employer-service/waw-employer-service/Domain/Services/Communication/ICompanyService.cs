using Models;

namespace waw_employer_service.Domain.Services.Communication
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> ListAll();
        Task<CompanyResponse> Create(Company company);
        Task<CompanyResponse> Update(long id, Company company);
        Task<CompanyResponse> Delete(long id);
    }

}
