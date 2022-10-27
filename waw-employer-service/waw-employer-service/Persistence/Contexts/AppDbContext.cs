using Microsoft.EntityFrameworkCore;
using waw_employer_service.Domain.Model;
using waw_employer_service.Extensions;

namespace waw_employer_service.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {       
        private DbSet<Company>? companies;       

        public DbSet<Company> Companies
        {
            get => GetContext(companies);
            set => companies = value;
        }       

        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);          

            var companyEntity = builder.Entity<Company>();
            companyEntity.ToTable("Companies");
            companyEntity.HasKey(p => p.Id);
            companyEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            companyEntity.Property(p => p.Name).IsRequired().HasMaxLength(100);
            companyEntity.Property(p => p.Address).HasMaxLength(256);
            companyEntity.Property(p => p.Email).IsRequired().HasMaxLength(256);

            builder.UseSnakeCase();
        }

        private static T GetContext<T>(T? ctx)
        {
            if (ctx == null) throw new NullReferenceException();
            return ctx;
        }
    }
}
