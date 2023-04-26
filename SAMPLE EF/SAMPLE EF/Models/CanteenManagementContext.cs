using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SAMPLE_EF.Models;

public partial class CanteenManagementContext : DbContext
{
    public CanteenManagementContext()
    {
    }

    public CanteenManagementContext(DbContextOptions<CanteenManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Menu> Menus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=DESKTOP-GL7RKG7\\SQLEXPRESS;database=Canteen_Management;integrated security=true;trustservercertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK_IID");

            entity.ToTable("MENU");

            entity.HasIndex(e => e.ItemName, "uk").IsUnique();

            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ItemType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Offer)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
