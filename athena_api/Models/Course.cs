namespace athena_api.Models;

public class Course
{
  public int CourseId { get; set; }
  public string Title { get; set; } = null!;
  public string Code { get; set; } = null!;
  public string Link { get; set; } = null!;
  public string Access { get; set; } = null!;
  public string CourseStatus { get; set; } = null!;
  public int? IdCompetence { get; set; }
}