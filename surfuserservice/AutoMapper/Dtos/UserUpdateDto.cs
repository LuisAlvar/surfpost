public class UserUpdateDto
{
  public Guid UserId { get; set; }
  
  public byte[] Image { get; set; }

  public bool Active { get; set; }

  public string LastPingLocation { get; set; }
}