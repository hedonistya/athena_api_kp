namespace athena_api.Models;

public class Schedule
{
  public int ScheduleId { get; set; }
  public DateTime ScheduleStartTime { get; set; }
  public DateTime ScheduleEndTime { get; set; }
  public int? IdMissionCourse { get; set; }
}