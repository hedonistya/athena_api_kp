using ApiHelper.ContextHelper;
using athena_api.Models;
using Microsoft.EntityFrameworkCore;

namespace athena_api.Context;

public class AthenaContext : ContextHelper
{
  public AthenaContext()
  {
  }

  public AthenaContext(DbContextOptions<AthenaContext> options)
    : base(
      "Server=sql5107.site4now.net;Database=db_a8415f_athena;User Id=db_a8415f_athena_admin;Password=1234Qwer#;Trusted_Connection=false;Integrated Security=false")
  {
  }

  public virtual DbSet<Comment> Comments { get; set; } = null!;
  public virtual DbSet<Competence> Competences { get; set; } = null!;
  public virtual DbSet<Course> Courses { get; set; } = null!;
  public virtual DbSet<Evaluation> Evaluations { get; set; } = null!;
  public virtual DbSet<Mission> Missions { get; set; } = null!;
  public virtual DbSet<MissionCourse> MissionCourses { get; set; } = null!;
  public virtual DbSet<MissionStatus> MissionStatuses { get; set; } = null!;
  public virtual DbSet<Schedule> Schedules { get; set; } = null!;
  public virtual DbSet<User> Users { get; set; } = null!;

  public override void OnModelCreatingAbstract(ModelBuilder modelBuilder)
  {
    modelBuilder.UseCollation("Cyrillic_General_CI_AS");

    modelBuilder.Entity<Comment>(entity =>
    {
      entity.Property(e => e.CommentId).HasColumnName("comment_id");

      entity.Property(e => e.CommentStatus)
        .HasMaxLength(10)
        .IsUnicode(false)
        .HasColumnName("comment_status");

      entity.Property(e => e.CommentTime)
        .HasColumnType("datetime")
        .HasColumnName("comment_time");

      entity.Property(e => e.Content)
        .HasColumnType("text")
        .HasColumnName("content");

      entity.Property(e => e.IdMissionCourse).HasColumnName("id_mission_course");

      entity.Property(e => e.IdUser).HasColumnName("id_user");
    });

    modelBuilder.Entity<Competence>(entity =>
    {
      entity.Property(e => e.CompetenceId).HasColumnName("competence_id");

      entity.Property(e => e.Title)
        .HasMaxLength(200)
        .IsUnicode(false)
        .HasColumnName("title");
    });

    modelBuilder.Entity<Course>(entity =>
    {
      entity.Property(e => e.CourseId).HasColumnName("course_id");

      entity.Property(e => e.Access)
        .HasMaxLength(50)
        .IsUnicode(false)
        .HasColumnName("access");

      entity.Property(e => e.Code)
        .HasMaxLength(8)
        .IsUnicode(false)
        .HasColumnName("code");

      entity.Property(e => e.CourseStatus)
        .HasMaxLength(10)
        .IsUnicode(false)
        .HasColumnName("course_status");

      entity.Property(e => e.IdCompetence).HasColumnName("id_competence");

      entity.Property(e => e.Link)
        .HasMaxLength(50)
        .IsUnicode(false)
        .HasColumnName("link");

      entity.Property(e => e.Title)
        .HasMaxLength(100)
        .IsUnicode(false)
        .HasColumnName("title");
    });

    modelBuilder.Entity<Evaluation>(entity =>
    {
      entity.Property(e => e.EvaluationId).HasColumnName("evaluation_id");

      entity.Property(e => e.EvaluationContent)
        .HasMaxLength(3)
        .IsUnicode(false)
        .HasColumnName("evaluation_content");

      entity.Property(e => e.IdCourse).HasColumnName("id_course");
    });

    modelBuilder.Entity<Mission>(entity =>
    {
      entity.ToTable("Mission");

      entity.Property(e => e.MissionId).HasColumnName("mission_id");

      entity.Property(e => e.Content)
        .HasColumnType("text")
        .HasColumnName("content");

      entity.Property(e => e.Title)
        .HasMaxLength(150)
        .IsUnicode(false)
        .HasColumnName("title");
    });

    modelBuilder.Entity<MissionCourse>(entity =>
    {
      entity.ToTable("Mission_Courses");

      entity.Property(e => e.MissionCourseId).HasColumnName("mission_course_id");

      entity.Property(e => e.IdCourse).HasColumnName("id_course");

      entity.Property(e => e.IdMission).HasColumnName("id_mission");

      entity.Property(e => e.MissionCourseStatus)
        .HasMaxLength(15)
        .IsUnicode(false)
        .HasColumnName("mission_course_status");
    });

    modelBuilder.Entity<MissionStatus>(entity =>
    {
      entity.ToTable("Mission_Statuses");

      entity.Property(e => e.MissionStatusId).HasColumnName("mission_status_id");

      entity.Property(e => e.IdMissionCourse).HasColumnName("id_mission_course");

      entity.Property(e => e.IdUser).HasColumnName("id_user");

      entity.Property(e => e.StatusEvaluation)
        .HasMaxLength(15)
        .IsUnicode(false)
        .HasColumnName("status_evaluation");
    });

    modelBuilder.Entity<Schedule>(entity =>
    {
      entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");

      entity.Property(e => e.IdMissionCourse).HasColumnName("id_mission_course");

      entity.Property(e => e.ScheduleEndTime)
        .HasColumnType("datetime")
        .HasColumnName("schedule_end_time");

      entity.Property(e => e.ScheduleStartTime)
        .HasColumnType("datetime")
        .HasColumnName("schedule_start_time");
    });

    modelBuilder.Entity<User>(entity =>
    {
      entity.Property(e => e.UserId).HasColumnName("user_id");

      entity.Property(e => e.Email)
        .HasMaxLength(50)
        .IsUnicode(false)
        .HasColumnName("email");

      entity.Property(e => e.UserStatus)
        .HasMaxLength(10)
        .IsUnicode(false)
        .HasColumnName("user_status");
    });
  }
}