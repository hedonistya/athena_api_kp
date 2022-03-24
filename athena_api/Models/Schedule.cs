using System;
using System.Collections.Generic;

namespace athena_api.Models
{
  public partial class Schedule
  {
    public int ScheduleId { get; set; }
    public DateTime ScheduleStartTime { get; set; }
    public DateTime ScheduleEndTime { get; set; }
    public int? IdMissionCourse { get; set; }

  }
}
