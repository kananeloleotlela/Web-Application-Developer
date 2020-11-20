using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _323Project2.Models;

namespace _323Project2.Data
{
    public partial class DimensionDataProjectDBContext : DbContext
    {
        public DimensionDataProjectDBContext()
        {
        }

        public DimensionDataProjectDBContext(DbContextOptions<DimensionDataProjectDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<DatasetTb> DatasetTb { get; set; }
        public virtual DbSet<EducationField> EducationField { get; set; }
        public virtual DbSet<EmployeeDetail> EmployeeDetail { get; set; }
        public virtual DbSet<EmployeeEducationInfo> EmployeeEducationInfo { get; set; }
        public virtual DbSet<EmployeeHistory> EmployeeHistory { get; set; }
        public virtual DbSet<JobInfo> JobInfo { get; set; }
        public virtual DbSet<JobRole> JobRole { get; set; }
        public virtual DbSet<LookupEducation> LookupEducation { get; set; }
        public virtual DbSet<LookupJob> LookupJob { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Initial Catalog=DimensionDataProjectDB;Data Source=LAPTOP-C6GB9IPI;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<DatasetTb>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.ToTable("DatasetTB");

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.BusinessTravel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EducationField)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobRole)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Over18)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EducationField>(entity =>
            {
                entity.HasKey(e => e.EducationCode)
                    .HasName("PK__Educatio__E2D8B715AADE968D");

                entity.Property(e => e.EducationDescription)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeDetail>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber)
                    .HasName("PK__Employee__8D663599B3F082B5");

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeEducationInfo>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNumber, e.EducationCode })
                    .HasName("PK_Education");

                entity.HasOne(d => d.EducationCodeNavigation)
                    .WithMany(p => p.EmployeeEducationInfo)
                    .HasForeignKey(d => d.EducationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeE__Educa__571DF1D5");

                entity.HasOne(d => d.EmployeeNumberNavigation)
                    .WithMany(p => p.EmployeeEducationInfo)
                    .HasForeignKey(d => d.EmployeeNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeE__Emplo__5629CD9C");
            });

            modelBuilder.Entity<EmployeeHistory>(entity =>
            {
                entity.Property(e => e.BusinessTravel).HasMaxLength(50);

                entity.Property(e => e.Over18).HasMaxLength(50);

                entity.HasOne(d => d.EmployeeNumberNavigation)
                    .WithMany(p => p.EmployeeHistory)
                    .HasForeignKey(d => d.EmployeeNumber)
                    .HasConstraintName("FK__EmployeeH__Emplo__59FA5E80");
            });

            modelBuilder.Entity<JobInfo>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeNumber, e.JobRoleCode })
                    .HasName("PK_Job");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.EmployeeNumberNavigation)
                    .WithMany(p => p.JobInfo)
                    .HasForeignKey(d => d.EmployeeNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JobInfo__Employe__5070F446");

                entity.HasOne(d => d.JobRoleCodeNavigation)
                    .WithMany(p => p.JobInfo)
                    .HasForeignKey(d => d.JobRoleCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__JobInfo__JobRole__5165187F");
            });

            modelBuilder.Entity<JobRole>(entity =>
            {
                entity.HasKey(e => e.JobRoleCode)
                    .HasName("PK__JobRole__D9D29CA1AF2BD104");

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LookupEducation>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.HasIndex(e => e.EmployeeNumber)
                    .HasName("IX_LookupEducation")
                    .IsUnique();

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();
            });

            modelBuilder.Entity<LookupJob>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
