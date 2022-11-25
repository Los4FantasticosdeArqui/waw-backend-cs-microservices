using waw_employer_service.Domain.Repositories;
using waw_employer_service.Persistence.Contexts;

namespace waw_employer_service.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;

        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
        }

        public async Task Complete()
        {
            await context.SaveChangesAsync();
        }
    }

}
