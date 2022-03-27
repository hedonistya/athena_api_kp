namespace athena_api.Models;

public class Comment
{
  public int CommentId { get; set; }
  public DateTime CommentTime { get; set; }
  public string Content { get; set; } = null!;
  public string CommentStatus { get; set; } = null!;
  public int? IdUser { get; set; }
  public int? IdMissionCourse { get; set; }
}