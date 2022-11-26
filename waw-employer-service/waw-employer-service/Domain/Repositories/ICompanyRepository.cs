using waw_employer_service.Domain.Model;

namespace waw_employer_service.Domain.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> ListAll();
        Task Add(Company company);
        Task<Company?> FindById(long id);
        Task<Company?> FindByName(string name);
        void Update(Company company);
        void Remove(Company company);
    }
}
