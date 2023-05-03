using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBFIRSToneToMany.Models;

public partial class BankContext : DbContext
{
    public BankContext()
    {
    }

    public BankContext(DbContextOptions<BankContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountInfo> AccountInfos { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=DESKTOP-GL7RKG7\\SQLEXPRESS;database=Bank;integrated security=true;trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountInfo>(entity =>
        {
            entity.HasKey(e => e.AccountNo).HasName("PK_ACNO");

            entity.ToTable("AccountInfo");

            entity.Property(e => e.AccName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Balance).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK_TID");

            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.Action)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ActionAmt).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.AccountNoNavigation).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.AccountNo)
                .HasConstraintName("FK_ACCNO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
