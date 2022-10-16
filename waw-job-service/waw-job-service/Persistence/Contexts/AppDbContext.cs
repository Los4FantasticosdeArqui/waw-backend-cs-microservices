using Microsoft.EntityFrameworkCore;
using waw_job_service.Domain.Model;
using waw_job_service.Extensions;

namespace waw_job_service.Persistence.Contexts;

public class AppDbContext : DbContext {
  private DbSet<Offer>? offers;
  
  public DbSet<Offer> Offers {
    get => GetContext(offers);
    set => offers = value;
  }
  
  public AppDbContext(DbContextOptions options) : base(options) {}

  protected override void OnModelCreating(ModelBuilder builder) {
    base.OnModelCreating(builder);
    
    var offerEntity = builder.Entity<Offer>();
    offerEntity.ToTable("Offers");
    offerEntity.HasKey(p => p.Id);
    offerEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    offerEntity.Property(p => p.Title).IsRequired().HasMaxLength(256);
    offerEntity.Property(p => p.Image).HasMaxLength(2048);
    offerEntity.Property(p => p.Description).IsRequired();
    offerEntity.Property(p => p.Status).IsRequired();

    builder.UseSnakeCase();
  }

  private static T GetContext<T>(T? ctx) {
    if (ctx == null) throw new NullReferenceException();
    return ctx;
  }
}
