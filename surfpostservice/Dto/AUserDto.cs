using System.ComponentModel.DataAnnotations;

public abstract class AUserDto
{
  [Required]
  public string? Name { get; set; }

  [Required]
  public byte[]? Image { get; set; }
}