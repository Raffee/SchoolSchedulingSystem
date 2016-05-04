using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using SchoolSchedulingSystem.Models;

namespace SchoolSchedulingSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160503170302_20160503")]
    partial class _20160503
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("State");

                    b.Property<string>("ZipCode");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("SchoolID");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseLevel");

                    b.Property<int?>("DepartmentID");

                    b.Property<string>("Name");

                    b.Property<int?>("SchoolID");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("HeadID");

                    b.Property<int>("Name");

                    b.Property<int?>("SchoolID");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.School", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abbreviation");

                    b.Property<int?>("AddressID");

                    b.Property<string>("DisplayName");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.SchoolClass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassLevel");

                    b.Property<string>("Name");

                    b.Property<int?>("SchoolID");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.SchoolConfiguration", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("SchoolID");

                    b.Property<string>("Value");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.Teacher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AvailabilityType");

                    b.Property<DateTime>("RegistrationDate");

                    b.Property<int?>("SchoolID");

                    b.Property<int?>("UserId");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("SchoolSchedulingSystem.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("SchoolSchedulingSystem.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("SchoolSchedulingSystem.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<int>", b =>
                {
                    b.HasOne("SchoolSchedulingSystem.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("SchoolSchedulingSystem.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.ApplicationUser", b =>
                {
                    b.HasOne("SchoolSchedulingSystem.Models.School")
                        .WithOne()
                        .HasForeignKey("SchoolSchedulingSystem.Models.ApplicationUser", "SchoolID");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.Course", b =>
                {
                    b.HasOne("SchoolSchedulingSystem.Models.Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID");

                    b.HasOne("SchoolSchedulingSystem.Models.School")
                        .WithMany()
                        .HasForeignKey("SchoolID");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.Department", b =>
                {
                    b.HasOne("SchoolSchedulingSystem.Models.Teacher")
                        .WithMany()
                        .HasForeignKey("HeadID");

                    b.HasOne("SchoolSchedulingSystem.Models.School")
                        .WithMany()
                        .HasForeignKey("SchoolID");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.School", b =>
                {
                    b.HasOne("SchoolSchedulingSystem.Models.Address")
                        .WithMany()
                        .HasForeignKey("AddressID");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.SchoolClass", b =>
                {
                    b.HasOne("SchoolSchedulingSystem.Models.School")
                        .WithMany()
                        .HasForeignKey("SchoolID");
                });

            modelBuilder.Entity("SchoolSchedulingSystem.Models.Teacher", b =>
                {
                    b.HasOne("SchoolSchedulingSystem.Models.School")
                        .WithMany()
                        .HasForeignKey("SchoolID");

                    b.HasOne("SchoolSchedulingSystem.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}
