using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Schedule;

public partial class ScheduleContext : DbContext
{
    public ScheduleContext()
    {
    }

    public ScheduleContext(DbContextOptions<ScheduleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Curriculum> Curriculums { get; set; }

    public virtual DbSet<Discipline> Disciplines { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<TeachersSubject> TeachersSubjects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Password=1111;Username=postgres;Database=Schedule");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Curriculum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("curriculum_pkey");

            entity.ToTable("curriculums");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('curriculum_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Hours1).HasColumnName("hours_1");
            entity.Property(e => e.Hours2).HasColumnName("hours_2");
            entity.Property(e => e.IdDiscipline).HasColumnName("id_discipline");
            entity.Property(e => e.IdModule).HasColumnName("id_module");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");

            entity.HasOne(d => d.IdDisciplineNavigation).WithMany(p => p.Curricula)
                .HasForeignKey(d => d.IdDiscipline)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("curriculums_id_discipline_fkey");

            entity.HasOne(d => d.IdModuleNavigation).WithMany(p => p.Curricula)
                .HasForeignKey(d => d.IdModule)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("curriculums_id_module_fkey");
        });

        modelBuilder.Entity<Discipline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("disciplines_pkey");

            entity.ToTable("disciplines");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("groups_pkey");

            entity.ToTable("groups");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Course).HasColumnName("course");
            entity.Property(e => e.DateOfAdmission).HasColumnName("date_of_admission");
            entity.Property(e => e.DateOfGraduation).HasColumnName("date_of_graduation");
            entity.Property(e => e.IdCurriculum).HasColumnName("id_curriculum");
            entity.Property(e => e.IdTeacher).HasColumnName("id_teacher");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");

            entity.HasOne(d => d.IdCurriculumNavigation).WithMany(p => p.Groups)
                .HasForeignKey(d => d.IdCurriculum)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("groups_id_curriculum_fkey");

            entity.HasOne(d => d.IdTeacherNavigation).WithMany(p => p.Groups)
                .HasForeignKey(d => d.IdTeacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("groups_id_teacher_fkey");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("modules_pkey");

            entity.ToTable("modules");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("subjects_pkey");

            entity.ToTable("subjects");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
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

        modelBuilder.Entity<TeachersSubject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("teachers_subjects_pkey1");

            entity.ToTable("teachers_subjects");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('teachers_subjects_id_seq1'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.IdSubject).HasColumnName("id_subject");
            entity.Property(e => e.IdTeacher).HasColumnName("id_teacher");

            entity.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.TeachersSubjects)
                .HasForeignKey(d => d.IdSubject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("teachers_subjects_id_subject_fkey");

            entity.HasOne(d => d.IdTeacherNavigation).WithMany(p => p.TeachersSubjects)
                .HasForeignKey(d => d.IdTeacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("teachers_subjects_id_teacher_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
