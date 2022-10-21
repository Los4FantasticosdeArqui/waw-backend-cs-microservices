using Microsoft.EntityFrameworkCore;
using AuthMicroservice.Domain.Models;
// using WAW.API.Employers.Domain.Models;
// using WAW.API.Job.Domain.Models;
// using WAW.API.Chat.Domain.Models;
using AuthMicroservice.Extensions;

namespace AuthMicroservice.Persistence.Contexts;

public class AppDbContext : DbContext {
  private DbSet<Offer>? offers;
  private DbSet<User>? users;
  private DbSet<Company>? companies;
  private DbSet<ChatRoom>? chatRooms;
  private DbSet<Message>? messages;
  private DbSet<ExternalImage>? images;
  private DbSet<UserEducation>? userEducation;
  private DbSet<UserExperience>? userExperience;
  private DbSet<UserProject>? userProject;

  public DbSet<Offer> Offers {
    get => GetContext(offers);
    set => offers = value;
  }

  public DbSet<User> Users {
    get => GetContext(users);
    set => users = value;
  }

  public DbSet<Company> Companies {
    get => GetContext(companies);
    set => companies = value;
  }

  public DbSet<ChatRoom> ChatRooms {
    get => GetContext(chatRooms);
    set => chatRooms = value;
  }

  public DbSet<Message> Messages {
    get => GetContext(messages);
    set => messages = value;
  }

  public DbSet<ExternalImage> Images {
    get => GetContext(images);
    set => images = value;
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

    var chatRoomEntity = builder.Entity<ChatRoom>();
    chatRoomEntity.ToTable("ChatRoom");
    chatRoomEntity.HasKey(p => p.Id);
    chatRoomEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    chatRoomEntity.Property(p => p.CreationDate).IsRequired();
    chatRoomEntity.Property(p => p.LastUpdateDate).IsRequired();
    chatRoomEntity.HasMany(p => p.Messages).WithOne(p => p.ChatRoom).HasForeignKey(p => p.ChatRoomId);
    chatRoomEntity.HasMany(p => p.Messages).WithOne(p => p.ChatRoom).HasForeignKey(p => p.ChatRoomId);

    var messageEntity = builder.Entity<Message>();
    messageEntity.ToTable("Message");
    messageEntity.HasKey(p => p.Id);
    messageEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    messageEntity.Property(p => p.Content).IsRequired().HasMaxLength(512);
    messageEntity.Property(p => p.Date).IsRequired();

    var offerEntity = builder.Entity<Offer>();
    offerEntity.ToTable("Offers");
    offerEntity.HasKey(p => p.Id);
    offerEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    offerEntity.Property(p => p.Title).IsRequired().HasMaxLength(256);
    offerEntity.Property(p => p.Image).HasMaxLength(2048);
    offerEntity.Property(p => p.Description).IsRequired();
    offerEntity.Property(p => p.Status).IsRequired();

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
    userEntity.HasMany(p => p.ChatRooms).WithMany(p => p.Participants);
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
    experienceEntity.HasOne(p => p.Company).WithOne().HasForeignKey<UserExperience>(p => p.CompanyId);

    var projectsEntity = builder.Entity<UserProject>();
    projectsEntity.ToTable("UserProject");
    projectsEntity.HasKey(p => p.Id);
    projectsEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    projectsEntity.Property(p => p.Title).IsRequired().HasMaxLength(100);
    projectsEntity.Property(p => p.Summary).IsRequired().HasMaxLength(500);
    projectsEntity.Property(p => p.Date).IsRequired();
    projectsEntity.HasOne(p => p.Image).WithOne().HasForeignKey<UserProject>(p => p.ImageId);

    var imageEntity = builder.Entity<ExternalImage>();
    imageEntity.ToTable("Images");
    imageEntity.HasKey(p => p.Id);
    imageEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    imageEntity.Property(p => p.Href).IsRequired().HasMaxLength(2000);
    imageEntity.Property(p => p.Alt).HasMaxLength(100);

    var companyEntity = builder.Entity<Company>();
    companyEntity.ToTable("Companies");
    companyEntity.HasKey(p => p.Id);
    companyEntity.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    companyEntity.Property(p => p.Name).IsRequired().HasMaxLength(100);
    companyEntity.Property(p => p.Address).HasMaxLength(256);
    companyEntity.Property(p => p.Email).IsRequired().HasMaxLength(256);

    builder.UseSnakeCase();
  }

  private static T GetContext<T>(T? ctx) {
    if (ctx == null) throw new NullReferenceException();
    return ctx;
  }
}
