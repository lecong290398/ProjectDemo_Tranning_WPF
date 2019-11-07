using System;
using Demo_Tranning_WPF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Demo_Tranning_WPF.Contexts
{
    public partial class QuanLyTTContext : DbContext
    {
        public QuanLyTTContext()
        {
        }

        public QuanLyTTContext(DbContextOptions<QuanLyTTContext> options)
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
        public virtual DbSet<DetailPlan> DetailPlan { get; set; }
        public virtual DbSet<DetailStock> DetailStock { get; set; }
        public virtual DbSet<FileAttachment> FileAttachment { get; set; }
        public virtual DbSet<GeneralStock> GeneralStock { get; set; }
        public virtual DbSet<InOutWard> InOutWard { get; set; }
        public virtual DbSet<InOutWardDetail> InOutWardDetail { get; set; }
        public virtual DbSet<InventoryItem> InventoryItem { get; set; }
        public virtual DbSet<InventoryItemLedger> InventoryItemLedger { get; set; }
        public virtual DbSet<ItemContainItem> ItemContainItem { get; set; }
        public virtual DbSet<ItemType> ItemType { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=101.99.32.48,9899;Database=QuanLyTT;User Id=sa;Password=1@qweQAZ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");
            });

            modelBuilder.Entity<DetailPlan>(entity =>
            {
                entity.HasOne(d => d.FK_PlanNavigation)
                    .WithMany(p => p.DetailPlan)
                    .HasForeignKey(d => d.FK_Plan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetailPlan_Plan");
            });

            modelBuilder.Entity<InOutWard>(entity =>
            {
                entity.HasOne(d => d.FK_Plan)
                    .WithMany(p => p.InOutWard)
                    .HasForeignKey(d => d.FK_PlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InOutWard_Plan");
            });

            modelBuilder.Entity<InventoryItem>(entity =>
            {
                entity.HasOne(d => d.FK_ItemTypeNavigation)
                    .WithMany(p => p.InventoryItem)
                    .HasForeignKey(d => d.FK_ItemType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryItem_ItemType");
            });

            modelBuilder.Entity<InventoryItemLedger>(entity =>
            {
                entity.HasOne(d => d.FK_InOutWardNavigation)
                    .WithMany(p => p.InventoryItemLedger)
                    .HasForeignKey(d => d.FK_InOutWard)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryItemLedger_InOutWard");
            });

            modelBuilder.Entity<ItemContainItem>(entity =>
            {
                entity.HasOne(d => d.FK_ChildItemNavigation)
                    .WithMany(p => p.ItemContainItemFK_ChildItemNavigation)
                    .HasForeignKey(d => d.FK_ChildItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemContainItem_InventoryItem1");

                entity.HasOne(d => d.FK_ParrentItemNavigation)
                    .WithMany(p => p.ItemContainItemFK_ParrentItemNavigation)
                    .HasForeignKey(d => d.FK_ParrentItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemContainItem_InventoryItem");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.Property(e => e.FK_ModifyObject).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
