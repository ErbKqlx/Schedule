using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Schedule_project.Models;

namespace Schedule_project;

public partial class ScheduleContext : DbContext
{
    public ScheduleContext()
    {
    }

    public ScheduleContext(DbContextOptions<ScheduleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Building> Buildings { get; set; }

    public virtual DbSet<Cabinet> Cabinets { get; set; }

    public virtual DbSet<Discipline> Disciplines { get; set; }

    public virtual DbSet<DisciplinesTeacher> DisciplinesTeachers { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Password=1111;Username=postgres;Database=schedule;Port=5432");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Building>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("buildings_pkey");

            entity.ToTable("buildings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.ShortName)
                .HasMaxLength(255)
                .HasColumnName("short_name");
        });

        modelBuilder.Entity<Cabinet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cabinets_pkey");

            entity.ToTable("cabinets");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdBuilding).HasColumnName("id_building");
            entity.Property(e => e.Number)
                .HasMaxLength(255)
                .HasColumnName("number");

            entity.HasOne(d => d.IdBuildingNavigation).WithMany(p => p.Cabinets)
                .HasForeignKey(d => d.IdBuilding)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cabinets_id_building_fkey");
        });

        modelBuilder.Entity<Discipline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("disciplines_pkey");

            entity.ToTable("disciplines");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DisciplinesTeacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("disciplines_teachers_pkey");

            entity.ToTable("disciplines_teachers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdDiscipline).HasColumnName("id_discipline");
            entity.Property(e => e.IdTeacher).HasColumnName("id_teacher");

            entity.HasOne(d => d.IdDisciplineNavigation).WithMany(p => p.DisciplinesTeachers)
                .HasForeignKey(d => d.IdDiscipline)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("disciplines_teachers_id_discipline_fkey");

            entity.HasOne(d => d.IdTeacherNavigation).WithMany(p => p.DisciplinesTeachers)
                .HasForeignKey(d => d.IdTeacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("disciplines_teachers_id_teacher_fkey");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("groups_pkey");

            entity.ToTable("groups");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.IdTeacher).HasColumnName("id_teacher");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.YearOfAdmission).HasColumnName("year_of_admission");
            entity.Property(e => e.YearOfGraduation).HasColumnName("year_of_graduation");

            entity.HasOne(d => d.IdTeacherNavigation).WithMany(p => p.Groups)
                .HasForeignKey(d => d.IdTeacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("groups_id_teacher_fkey");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("schedule_pkey");

            entity.ToTable("schedule");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.IdCabinet).HasColumnName("id_cabinet");
            entity.Property(e => e.IdDisciplineTeacher).HasColumnName("id_discipline_teacher");
            entity.Property(e => e.IdGroup).HasColumnName("id_group");
            entity.Property(e => e.Number).HasColumnName("number");

            entity.HasOne(d => d.IdCabinetNavigation).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.IdCabinet)
                .HasConstraintName("schedule_id_cabinet_fkey");

            entity.HasOne(d => d.IdDisciplineTeacherNavigation).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.IdDisciplineTeacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("schedule_id_discipline_teacher_fkey");

            entity.HasOne(d => d.IdGroupNavigation).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.IdGroup)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("schedule_id_group_fkey");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teachers_pkey");

            entity.ToTable("teachers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(255)
                .HasColumnName("patronymic");
            entity.Property(e => e.Surname)
                .HasMaxLength(255)
                .HasColumnName("surname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
