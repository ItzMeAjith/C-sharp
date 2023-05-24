using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Kanini_Workspace.Models;

public partial class KaniniWorkspaceContext : DbContext
{
    public KaniniWorkspaceContext()
    {
    }

    public KaniniWorkspaceContext(DbContextOptions<KaniniWorkspaceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AuthTbl> AuthTbls { get; set; }

    public virtual DbSet<DbookingTbl> DbookingTbls { get; set; }

    public virtual DbSet<EventTbl> EventTbls { get; set; }

    public virtual DbSet<EventjoinTbl> EventjoinTbls { get; set; }

    public virtual DbSet<LocationTbl> LocationTbls { get; set; }

    public virtual DbSet<NotificationTbl> NotificationTbls { get; set; }

    public virtual DbSet<RbookingTbl> RbookingTbls { get; set; }

    public virtual DbSet<RoomTbl> RoomTbls { get; set; }

    public virtual DbSet<UserTbl> UserTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=DESKTOP-GL7RKG7\\SQLEXPRESS;database=KaniniWorkspace;integrated security=true;trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuthTbl>(entity =>
        {
            entity.HasKey(e => e.AuthId).HasName("PK__auth_tbl__6531B6F5B1D7BAA3");

            entity.ToTable("auth_tbl");

            entity.Property(e => e.AuthId).HasColumnName("auth_id");
            entity.Property(e => e.AuthEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("auth_email");
            entity.Property(e => e.AuthEmpid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("auth_empid");
            entity.Property(e => e.AuthPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("auth_password");
        });

        modelBuilder.Entity<DbookingTbl>(entity =>
        {
            entity.HasKey(e => e.DbookingId).HasName("PK__dbooking__4756A52C98EF3C69");

            entity.ToTable("dbooking_tbl");

            entity.Property(e => e.DbookingId).HasColumnName("dbooking_id");
            entity.Property(e => e.DbookingColl)
                .HasMaxLength(100)
                .HasColumnName("dbooking_coll");
            entity.Property(e => e.DbookingDate)
                .HasColumnType("date")
                .HasColumnName("dbooking_date");
            entity.Property(e => e.DbookingLocid).HasColumnName("dbooking_locid");

            entity.HasOne(d => d.DbookingLoc).WithMany(p => p.DbookingTbls)
                .HasForeignKey(d => d.DbookingLocid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__dbooking___dbook__5165187F");
        });

        modelBuilder.Entity<EventTbl>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__event_tb__2370F72781B2F40F");

            entity.ToTable("event_tbl");

            entity.Property(e => e.EventId).HasColumnName("event_id");
            entity.Property(e => e.EventDate)
                .HasColumnType("date")
                .HasColumnName("event_date");
            entity.Property(e => e.EventDesc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("event_desc");
            entity.Property(e => e.EventEndtime).HasColumnName("event_endtime");
            entity.Property(e => e.EventLocid).HasColumnName("event_locid");
            entity.Property(e => e.EventName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("event_name");
            entity.Property(e => e.EventStarttime).HasColumnName("event_starttime");

            entity.HasOne(d => d.EventLoc).WithMany(p => p.EventTbls)
                .HasForeignKey(d => d.EventLocid)
                .HasConstraintName("FK_event_tbl_location_tbl");
        });

        modelBuilder.Entity<EventjoinTbl>(entity =>
        {
            entity.HasKey(e => e.EventjoinId).HasName("PK__eventjoi__FF4E5F97AFA64FA9");

            entity.ToTable("eventjoin_tbl");

            entity.Property(e => e.EventjoinId)
                .ValueGeneratedNever()
                .HasColumnName("eventjoin_id");
            entity.Property(e => e.TotalEventjoin).HasColumnName("total_eventjoin");

            entity.HasOne(d => d.Eventjoin).WithOne(p => p.EventjoinTbl)
                .HasForeignKey<EventjoinTbl>(d => d.EventjoinId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_eventjoin_tbl_event_tbl");
        });

        modelBuilder.Entity<LocationTbl>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__location__771831EAD32EA0DC");

            entity.ToTable("location_tbl");

            entity.Property(e => e.LocationId).HasColumnName("location_id");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(100)
                .HasColumnName("location_city");
        });

        modelBuilder.Entity<NotificationTbl>(entity =>
        {
            entity.HasKey(e => e.NotifId).HasName("PK__notifica__CDF18E6C12C96B67");

            entity.ToTable("notification_tbl");

            entity.Property(e => e.NotifId).HasColumnName("notif_id");
            entity.Property(e => e.NotifDate)
                .HasColumnType("date")
                .HasColumnName("notif_date");
            entity.Property(e => e.NotifDesc)
                .HasMaxLength(1000)
                .HasColumnName("notif_desc");
            entity.Property(e => e.NotifLoc).HasColumnName("notif_loc");
            entity.Property(e => e.NotifTime).HasColumnName("notif_time");
            entity.Property(e => e.NotifTitle)
                .HasMaxLength(100)
                .HasColumnName("notif_title");

            entity.HasOne(d => d.NotifLocNavigation).WithMany(p => p.NotificationTbls)
                .HasForeignKey(d => d.NotifLoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__notificat__notif__4E88ABD4");
        });

        modelBuilder.Entity<RbookingTbl>(entity =>
        {
            entity.HasKey(e => e.RbookingId).HasName("PK__rbooking__4ABC1DF34F6FB540");

            entity.ToTable("rbooking_tbl");

            entity.Property(e => e.RbookingId).HasColumnName("rbooking_id");
            entity.Property(e => e.RbookingDate)
                .HasColumnType("date")
                .HasColumnName("rbooking_date");
            entity.Property(e => e.RbookingEmp).HasColumnName("rbooking_emp");
            entity.Property(e => e.RbookingLocid).HasColumnName("rbooking_locid");
            entity.Property(e => e.RmeetingDesc)
                .HasMaxLength(255)
                .HasColumnName("rmeeting_desc");
            entity.Property(e => e.RoomId).HasColumnName("room_id");

            entity.HasOne(d => d.RbookingLoc).WithMany(p => p.RbookingTbls)
                .HasForeignKey(d => d.RbookingLocid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__rbooking___rbook__5535A963");

            entity.HasOne(d => d.Room).WithMany(p => p.RbookingTbls)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__rbooking___room___5441852A");
        });

        modelBuilder.Entity<RoomTbl>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__room_tbl__19675A8ADB935B87");

            entity.ToTable("room_tbl");

            entity.Property(e => e.RoomId).HasColumnName("room_id");
            entity.Property(e => e.Additional)
                .HasMaxLength(100)
                .HasColumnName("additional");
            entity.Property(e => e.Presentation)
                .HasMaxLength(100)
                .HasColumnName("presentation");
            entity.Property(e => e.RoomCapacity).HasColumnName("room_capacity");
            entity.Property(e => e.RoomLocid).HasColumnName("room_locid");
            entity.Property(e => e.RoomName)
                .HasMaxLength(100)
                .HasColumnName("room_name");

            entity.HasOne(d => d.RoomLoc).WithMany(p => p.RoomTbls)
                .HasForeignKey(d => d.RoomLocid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__room_tbl__room_l__4BAC3F29");
        });

        modelBuilder.Entity<UserTbl>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__user_tbl__B9BE370FB33B6759");

            entity.ToTable("user_tbl", tb => tb.HasTrigger("trgInsertAuth"));

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.UserDept)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_dept");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_email");
            entity.Property(e => e.UserEmpid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("user_empid");
            entity.Property(e => e.UserFirstname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_firstname");
            entity.Property(e => e.UserLastname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_lastname");
            entity.Property(e => e.UserLocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_location");
            entity.Property(e => e.UserPhonenumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("user_phonenumber");
            entity.Property(e => e.UserTitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
