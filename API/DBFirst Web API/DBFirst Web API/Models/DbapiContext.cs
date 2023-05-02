using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBFirst_Web_API.Models;

public partial class DbapiContext : DbContext
{
    public DbapiContext()
    {
    }

    public DbapiContext(DbContextOptions<DbapiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Menu> Menus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-GL7RKG7\\SQLEXPRESS;database=DBAPI;integrated security =true;trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.ItemId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
