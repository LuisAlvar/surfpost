using System.ComponentModel.DataAnnotations;

public class PostCreateDto
{
  [Required]
  public string? Title { get; set; }

  [Required]
  public string? Descrption { get; set; }

  [Required]
  public User? User { get; set; }
  
  public List<User>? TagUsers { get; set; }
}