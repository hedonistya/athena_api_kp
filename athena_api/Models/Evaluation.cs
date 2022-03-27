namespace athena_api.Models;

public class Evaluation
{
  public int EvaluationId { get; set; }
  public string EvaluationContent { get; set; } = null!;
  public int? IdCourse { get; set; }
}