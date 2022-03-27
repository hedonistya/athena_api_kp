namespace athena_api.Models;

public class MissionCourse
{
  public int MissionCourseId { get; set; }
  public string MissionCourseStatus { get; set; } = null!;
  public int? IdCourse { get; set; }
  public int? IdMission { get; set; }
}