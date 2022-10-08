using System.ComponentModel.DataAnnotations;

public class UserUpdateDto: AUserDto
{
  [Required]
  public int iPost { get; set; }
}