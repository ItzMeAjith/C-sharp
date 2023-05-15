using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Online_Education_Provider.Models;

public partial class OnlineEducationProviderContext : DbContext
{
    public OnlineEducationProviderContext()
    {
    }

    public OnlineEducationProviderContext(DbContextOptions<OnlineEducationProviderContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Quiz> Quizzes { get; set; }

    public virtual DbSet<UserRegistration> UserRegistrations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=DESKTOP-GL7RKG7\\SQLEXPRESS;database=Online_Education_Provider;integrated security=true;trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK_CID");

            entity.ToTable("Course");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.CourseDuration)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CourseFees).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CourseName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Quiz>(entity =>
        {
            entity.HasKey(e => e.QuizId).HasName("PK_QID");

            entity.ToTable("Quiz");

            entity.Property(e => e.QuizId).HasColumnName("QuizID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.QuizDifLevel)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.QuizName)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Course).WithMany(p => p.Quizzes)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CID");
        });

        modelBuilder.Entity<UserRegistration>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_UID");

            entity.ToTable("User_Registration");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.MailId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MailID");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
