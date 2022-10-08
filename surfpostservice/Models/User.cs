using System.ComponentModel.DataAnnotations;

public class User
{
  [Key]
  public Guid UserId { get; set;}

  [Required]
  public string Name { get; set; }

  [Required]
  public Byte[] Image { get; set;}

  [Required]
  public int iPost { get; set;}
}