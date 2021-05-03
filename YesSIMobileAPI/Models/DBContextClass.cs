using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace YesSIMobileAPI.Models
{
    public partial class DBContextClass : DbContext
    {
        public DBContextClass()
        {
        }

        public DBContextClass(DbContextOptions<DBContextClass> options)
            : base(options)
        {
        }

        public virtual DbSet<AdmAppSession> AdmAppSessions { get; set; }
        public virtual DbSet<AdmLicense> AdmLicenses { get; set; }
        public virtual DbSet<AdmRole> AdmRoles { get; set; }
        public virtual DbSet<AdmRoleType> AdmRoleTypes { get; set; }
        public virtual DbSet<AdmUser> AdmUsers { get; set; }
        public virtual DbSet<CfgTier> CfgTiers { get; set; }
        public virtual DbSet<CfgTierType> CfgTierTypes { get; set; }
        public virtual DbSet<SysBlackListToken> SysBlackListTokens { get; set; }
        public virtual DbSet<SysResetPasswordAppRequest> SysResetPasswordAppRequests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-HHCPCM3\\SQLEXPRESS;Initial Catalog=YesSIMobile;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<AdmAppSession>(entity =>
            {
                entity.HasKey(e => e.Pkey)
                    .HasName("AdmAppSession_PK");

                entity.Property(e => e.Pkey).ValueGeneratedNever();
            });

            modelBuilder.Entity<AdmLicense>(entity =>
            {
                entity.HasKey(e => e.Pkey)
                    .HasName("AdmLicenseKey_PK");

                entity.Property(e => e.Pkey).ValueGeneratedNever();

                entity.HasOne(d => d.AdmUser)
                    .WithMany(p => p.AdmLicenses)
                    .HasForeignKey(d => d.AdmUserId)
                    .HasConstraintName("AdmLicense_AdmUserId_FK1");
            });

            modelBuilder.Entity<AdmRole>(entity =>
            {
                entity.HasKey(e => e.Pkey)
                    .HasName("AdmRoleKey_PK");

                entity.Property(e => e.Pkey).ValueGeneratedNever();

                entity.HasOne(d => d.AdmRoleType)
                    .WithMany(p => p.AdmRoles)
                    .HasForeignKey(d => d.AdmRoleTypeId)
                    .HasConstraintName("AdmRole_AdmRoleType_FK1");
            });

            modelBuilder.Entity<AdmRoleType>(entity =>
            {
                entity.HasKey(e => e.Pkey)
                    .HasName("AdmRoleTypeKey_PK");

                entity.Property(e => e.Pkey).ValueGeneratedNever();
            });

            modelBuilder.Entity<AdmUser>(entity =>
            {
                entity.HasKey(e => e.Pkey)
                    .HasName("AdmUser_PK");

                entity.Property(e => e.Pkey).ValueGeneratedNever();

                entity.Property(e => e.Code).IsUnicode(false);
            });

            modelBuilder.Entity<CfgTier>(entity =>
            {
                entity.HasKey(e => e.Pkey)
                    .HasName("CfgTierKey_PK");

                entity.Property(e => e.Pkey).ValueGeneratedNever();

                entity.HasOne(d => d.CfgTierType)
                    .WithMany(p => p.CfgTiers)
                    .HasForeignKey(d => d.CfgTierTypeId)
                    .HasConstraintName("CfgTier_CfgTierType_FK1");
            });

            modelBuilder.Entity<CfgTierType>(entity =>
            {
                entity.HasKey(e => e.Pkey)
                    .HasName("CfgTierTypeKey_PK");

                entity.Property(e => e.Pkey).ValueGeneratedNever();
            });

            modelBuilder.Entity<SysBlackListToken>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<SysResetPasswordAppRequest>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SysResetPasswordAppRequests)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserID_AdmUserID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
