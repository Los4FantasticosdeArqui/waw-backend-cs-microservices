using Microsoft.EntityFrameworkCore;
using waw_auth_service.Domain.Models;
using waw_auth_service.Extensions;
// using WAW.API.Employers.Domain.Models;
// using WAW.API.Job.Domain.Models;
// using WAW.API.Chat.Domain.Models;

namespace waw_auth_service.Persistence.Contexts;

public class AppDbContext : DbContext {
 
  private DbSet<User>? users;
  private DbSet<UserEducation>? userEducation;
  private DbSet<UserExperience>? userExperience;
  private DbSet<UserProject>? userProject;

  

  public DbSet<User> Users {
    get => GetContext(users);
    set => users = value;
  }

  public DbSet<UserEducation> UserEducation {
    get => GetContext(userEducation);
    set => userEducation = value;
  }

  public DbSet<UserExperience> UserExperience {
    get => GetContext(userExperience);
    set => userExperience = value;
  }

  public DbSet<UserProject> UserProject {
    get => GetContext(userProject);
    set => userProject = value;
  }
 


  public AppDbContext(DbContextOptions options) : base(options) {}

  protected override void OnModelCreating(ModelBuilder builder) {
    base.OnModelCreating(builder);
    
    var userEntity = builder.Entity<User>();
    userEntity.ToTable("Users");
    userEntity.HasKey(p => p.Id);
    userEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    userEntity.Property(p => p.FullName).IsRequired().HasMaxLength(256);
    userEntity.Property(p => p.PreferredName).IsRequired().HasMaxLength(256);
    userEntity.Property(p => p.Email).IsRequired().HasMaxLength(254);
    userEntity.Property(p => p.ProfileViews).HasDefaultValue(0);
    userEntity.Property(p => p.Birthdate).IsRequired();
    userEntity.Property(p => p.Password).IsRequired().HasMaxLength(60);
    //userEntity.HasMany(p => p.ChatRooms).WithMany(p => p.Participants);
    userEntity.HasMany(p => p.Education).WithOne(p => p.User).HasForeignKey(p => p.UserId).IsRequired();
    userEntity.HasMany(p => p.Experience).WithOne(p => p.User).HasForeignKey(p => p.UserId).IsRequired();
    userEntity.HasMany(p => p.Projects).WithOne(p => p.User).HasForeignKey(p => p.UserId).IsRequired();
    userEntity.HasOne(p => p.Cover).WithOne().HasForeignKey<User>(p => p.CoverId);
    userEntity.HasOne(p => p.Picture).WithOne().HasForeignKey<User>(p => p.PictureId);

    var educationEntity = builder.Entity<UserEducation>();
    educationEntity.ToTable("UserEducation");
    educationEntity.HasKey(p => p.Id);
    educationEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    educationEntity.Property(p => p.University).IsRequired().HasMaxLength(200);
    educationEntity.Property(p => p.Description).IsRequired().HasMaxLength(500);
    educationEntity.Property(p => p.StartYear).IsRequired();
    educationEntity.Property(p => p.EndYear).IsRequired();
    educationEntity.HasOne(p => p.Image).WithOne().HasForeignKey<UserEducation>(p => p.ImageId);

    var experienceEntity = builder.Entity<UserExperience>();
    experienceEntity.ToTable("UserExperience");
    experienceEntity.HasKey(p => p.Id);
    experienceEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    experienceEntity.Property(p => p.Title).IsRequired().HasMaxLength(256);
    experienceEntity.Property(p => p.Location).IsRequired().HasMaxLength(100);
    experienceEntity.Property(p => p.StartDate).IsRequired();
    experienceEntity.Property(p => p.EndDate).IsRequired();
    experienceEntity.Property(p => p.TimeDiff).IsRequired().HasMaxLength(100);
    experienceEntity.Property(p => p.Description).IsRequired().HasMaxLength(5000);
    experienceEntity.HasOne(p => p.Image).WithOne().HasForeignKey<UserExperience>(p => p.ImageId);
    // experienceEntity.HasOne(p => p.Company).WithOne().HasForeignKey<UserExperience>(p => p.CompanyId);

    var projectsEntity = builder.Entity<UserProject>();
    projectsEntity.ToTable("UserProject");
    projectsEntity.HasKey(p => p.Id);
    projectsEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    projectsEntity.Property(p => p.Title).IsRequired().HasMaxLength(100);
    projectsEntity.Property(p => p.Summary).IsRequired().HasMaxLength(500);
    projectsEntity.Property(p => p.Date).IsRequired();
    projectsEntity.HasOne(p => p.Image).WithOne().HasForeignKey<UserProject>(p => p.ImageId);

 
    builder.UseSnakeCase();
  }

  private static T GetContext<T>(T? ctx) {
    if (ctx == null) throw new NullReferenceException();
    return ctx;
  }
}
