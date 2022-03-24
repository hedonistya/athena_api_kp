using System;
using System.Collections.Generic;

namespace athena_api.Models
{
    public partial class MissionCourse
    {
      

        public int MissionCourseId { get; set; }
        public string MissionCourseStatus { get; set; } = null!;
        public int? IdCourse { get; set; }
        public int? IdMission { get; set; }

       
    }
}
