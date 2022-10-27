using waw_employer_service.Persistence.Contexts;

namespace waw_employer_service.Persistence.Repositories
{
    public class BaseRepository
    {
        protected readonly AppDbContext context;

        public BaseRepository(AppDbContext context)
        {
            this.context = context;
        }
    }

}
