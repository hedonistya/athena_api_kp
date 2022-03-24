using System;
using System.Collections.Generic;

namespace athena_api.Models
{
    public partial class MissionStatus
    {
        public int MissionStatusId { get; set; }
        public string StatusEvaluation { get; set; } = null!;
        public int? IdMissionCourse { get; set; }
        public int? IdUser { get; set; }

       
    }
}
