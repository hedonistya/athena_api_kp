namespace athena_api.Models;

public class Mission
{
  public int MissionId { get; set; }
  public string Title { get; set; } = null!;
  public string? Content { get; set; }
}