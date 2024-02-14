using System;
using System.Collections.Generic;
using LastPractical.Entities;
using Microsoft.EntityFrameworkCore;

namespace LastPractical.Context;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<EquipmentApplication> EquipmentApplications { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<TypeMalfunction> TypeMalfunctions { get; set; }

    public virtual DbSet<TypeMalfunctionApplication> TypeMalfunctionApplications { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=korhovvv\\KORHOVVV;Database=ispp01up01;User Id=ispp01up01;Password=01;TrustServerCertificate=true;Trusted_Connection=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Application>(entity =>
        {
            entity.ToTable("Application");

            entity.Property(e => e.DateApplication).HasColumnType("date");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.WorkTime).HasMaxLength(8);

            entity.HasOne(d => d.Status).WithMany(p => p.Applications)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Application_Status1");

            entity.HasOne(d => d.UserIdClientNavigation).WithMany(p => p.ApplicationUserIdClientNavigations)
                .HasForeignKey(d => d.UserIdClient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Application_User");

            entity.HasOne(d => d.UserIdExecutorNavigation).WithMany(p => p.ApplicationUserIdExecutorNavigations)
                .HasForeignKey(d => d.UserIdExecutor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Application_User2");
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<EquipmentApplication>(entity =>
        {
            entity.HasKey(e => new { e.EquipmentId, e.ApplicationId });

            entity.ToTable("EquipmentApplication");

            entity.HasOne(d => d.Application).WithMany(p => p.EquipmentApplications)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EquipmentApplication_Application");

            entity.HasOne(d => d.Equipment).WithMany(p => p.EquipmentApplications)
                .HasForeignKey(d => d.EquipmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EquipmentApplication_Equipment");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.NameRole).HasMaxLength(50);
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.ToTable("Status");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TypeMalfunction>(entity =>
        {
            entity.ToTable("TypeMalfunction");

            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<TypeMalfunctionApplication>(entity =>
        {
            entity.HasKey(e => new { e.TypeMalfunctionId, e.ApplicationId });

            entity.ToTable("TypeMalfunctionApplication");

            entity.Property(e => e.Count).HasColumnName("count");

            entity.HasOne(d => d.Application).WithMany(p => p.TypeMalfunctionApplications)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TypeMalfunctionApplication_Application");

            entity.HasOne(d => d.TypeMalfunction).WithMany(p => p.TypeMalfunctionApplications)
                .HasForeignKey(d => d.TypeMalfunctionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TypeMalfunctionApplication_TypeMalfunction");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.PatronymicName).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.SecondName).HasMaxLength(50);

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
