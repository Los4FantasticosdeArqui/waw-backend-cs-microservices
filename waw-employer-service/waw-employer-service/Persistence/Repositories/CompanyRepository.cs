using Domain.Models;
using Microsoft.EntityFrameworkCore;
using waw_employer_service.Domain.Repositories;
using waw_employer_service.Persistence.Contexts;
using waw_employer_service.Persistence.Repositories;

namespace waw_employer_service.Persistence.Repositories
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Company>> ListAll()
        {
            return await context.Companies.ToListAsync();
        }

        public async Task Add(Company company)
        {
            await context.Companies.AddAsync(company);
        }

        public async Task<Company?> FindById(long id)
        {
            return await context.Companies.FindAsync(id);
        }

        public async Task<Company?> FindByName(string name)
        {
            return await context.Companies.FirstOrDefaultAsync(p => p.Name == name);
        }

        public void Update(Company company)
        {
            context.Companies.Update(company);
        }

        public void Remove(Company company)
        {
            context.Companies.Remove(company);
        }
    }
}
