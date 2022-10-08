public class UserReadDto
{
  public Guid UserId { get; set; }

  public string Name { get; set; }

  public byte[] Image { get; set; }

  public string UserName { get; set; }

  public string LastPingLocation { get; set; }
}