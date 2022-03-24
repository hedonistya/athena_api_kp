using System;
using System.Collections.Generic;

namespace athena_api.Models
{
    public partial class Evaluation
    {
        public int EvaluationId { get; set; }
        public string EvaluationContent { get; set; } = null!;
        public int? IdCourse { get; set; }

       
    }
}
