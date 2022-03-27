namespace athena_api.Models;

public class User
{
  public int UserId { get; set; }
  public string Email { get; set; } = null!;
  public string UserStatus { get; set; } = null!;
}