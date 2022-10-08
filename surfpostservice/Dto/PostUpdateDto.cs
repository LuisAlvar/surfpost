using System.ComponentModel.DataAnnotations;

public class PostUpdateDto
{
  [Required]
  public string? Title { get; set; }
  
  [Required]
  public string? Descrption { get; set; }
  
  [Required]
  public bool IsEdit { get; set; }

  public List<User>? TagUsers { get; set; }
}