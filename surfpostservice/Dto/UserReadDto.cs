using System.ComponentModel.DataAnnotations;

public class UserReadDto: AUserDto
{
  [Required]
  public int iPost { get; set; }
}