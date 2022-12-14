// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using waw_auth_service.Persistence.Contexts;

#nullable disable

namespace waw_auth_service.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("waw_auth_service.Domain.Models.ExternalImage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Alt")
                        .HasColumnType("longtext")
                        .HasColumnName("alt");

                    b.Property<string>("Href")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("href");

                    b.HasKey("Id")
                        .HasName("p_k_external_image");

                    b.ToTable("external_image");
                });

            modelBuilder.Entity("waw_auth_service.Domain.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("About")
                        .HasColumnType("longtext")
                        .HasColumnName("about");

                    b.Property<string>("Biography")
                        .HasColumnType("longtext")
                        .HasColumnName("biography");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("birthdate");

                    b.Property<long?>("CoverId")
                        .HasColumnType("bigint")
                        .HasColumnName("cover_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(254)
                        .HasColumnType("varchar(254)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("full_name");

                    b.Property<string>("Location")
                        .HasColumnType("longtext")
                        .HasColumnName("location");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("password");

                    b.Property<long?>("PictureId")
                        .HasColumnType("bigint")
                        .HasColumnName("picture_id");

                    b.Property<string>("PreferredName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("preferred_name");

                    b.Property<int>("ProfileViews")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("profile_views");

                    b.HasKey("Id")
                        .HasName("p_k_users");

                    b.HasIndex("CoverId")
                        .IsUnique()
                        .HasDatabaseName("i_x_users_cover_id");

                    b.HasIndex("PictureId")
                        .IsUnique()
                        .HasDatabaseName("i_x_users_picture_id");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("waw_auth_service.Domain.Models.UserEducation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<int>("EndYear")
                        .HasColumnType("int")
                        .HasColumnName("end_year");

                    b.Property<long?>("ImageId")
                        .HasColumnType("bigint")
                        .HasColumnName("image_id");

                    b.Property<int>("StartYear")
                        .HasColumnType("int")
                        .HasColumnName("start_year");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("university");

                    b.Property<long?>("UserId")
                        .IsRequired()
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("p_k_user_education");

                    b.HasIndex("ImageId")
                        .IsUnique()
                        .HasDatabaseName("i_x_user_education_image_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("i_x_user_education_user_id");

                    b.ToTable("user_education", (string)null);
                });

            modelBuilder.Entity("waw_auth_service.Domain.Models.UserExperience", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("varchar(5000)")
                        .HasColumnName("description");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("end_date");

                    b.Property<long?>("ImageId")
                        .HasColumnType("bigint")
                        .HasColumnName("image_id");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("location");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("start_date");

                    b.Property<string>("TimeDiff")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("time_diff");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("title");

                    b.Property<long?>("UserId")
                        .IsRequired()
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("p_k_user_experience");

                    b.HasIndex("ImageId")
                        .IsUnique()
                        .HasDatabaseName("i_x_user_experience_image_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("i_x_user_experience_user_id");

                    b.ToTable("user_experience", (string)null);
                });

            modelBuilder.Entity("waw_auth_service.Domain.Models.UserProject", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<long?>("ImageId")
                        .HasColumnType("bigint")
                        .HasColumnName("image_id");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("summary");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("title");

                    b.Property<long?>("UserId")
                        .IsRequired()
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("p_k_user_project");

                    b.HasIndex("ImageId")
                        .IsUnique()
                        .HasDatabaseName("i_x_user_project_image_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("i_x_user_project_user_id");

                    b.ToTable("user_project", (string)null);
                });

            modelBuilder.Entity("waw_auth_service.Domain.Models.User", b =>
                {
                    b.HasOne("waw_auth_service.Domain.Models.ExternalImage", "Cover")
                        .WithOne()
                        .HasForeignKey("waw_auth_service.Domain.Models.User", "CoverId")
                        .HasConstraintName("f_k_users_external_image_cover_id");

                    b.HasOne("waw_auth_service.Domain.Models.ExternalImage", "Picture")
                        .WithOne()
                        .HasForeignKey("waw_auth_service.Domain.Models.User", "PictureId")
                        .HasConstraintName("f_k_users_external_image_picture_id");

                    b.Navigation("Cover");

                    b.Navigation("Picture");
                });

            modelBuilder.Entity("waw_auth_service.Domain.Models.UserEducation", b =>
                {
                    b.HasOne("waw_auth_service.Domain.Models.ExternalImage", "Image")
                        .WithOne()
                        .HasForeignKey("waw_auth_service.Domain.Models.UserEducation", "ImageId")
                        .HasConstraintName("f_k_user_education_external_image_image_id");

                    b.HasOne("waw_auth_service.Domain.Models.User", "User")
                        .WithMany("Education")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("f_k_user_education_users_user_id");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("waw_auth_service.Domain.Models.UserExperience", b =>
                {
                    b.HasOne("waw_auth_service.Domain.Models.ExternalImage", "Image")
                        .WithOne()
                        .HasForeignKey("waw_auth_service.Domain.Models.UserExperience", "ImageId")
                        .HasConstraintName("f_k_user_experience_external_image_image_id");

                    b.HasOne("waw_auth_service.Domain.Models.User", "User")
                        .WithMany("Experience")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("f_k_user_experience_users_user_id");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("waw_auth_service.Domain.Models.UserProject", b =>
                {
                    b.HasOne("waw_auth_service.Domain.Models.ExternalImage", "Image")
                        .WithOne()
                        .HasForeignKey("waw_auth_service.Domain.Models.UserProject", "ImageId")
                        .HasConstraintName("f_k_user_project_external_image_image_id");

                    b.HasOne("waw_auth_service.Domain.Models.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("f_k_user_project_users_user_id");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("waw_auth_service.Domain.Models.User", b =>
                {
                    b.Navigation("Education");

                    b.Navigation("Experience");

                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
