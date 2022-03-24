using System;
using System.Collections.Generic;

namespace athena_api.Models
{
    public partial class Mission
    {
      

        public int MissionId { get; set; }
        public string Title { get; set; } = null!;
        public string? Content { get; set; }

      
    }
}
