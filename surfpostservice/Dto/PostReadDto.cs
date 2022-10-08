using System.ComponentModel.DataAnnotations;

public class PostReadDto
{
  [Required]
  public string? Title { get; set; }

  [Required]
  public string? Description { get; set; }

  [Required]
  public int iLoves { get; set; }

  [Required]
  public int iViews  { get; set; }

  [Required]
  public bool isEdit { get; set; }

  [Required]
  public User? User { get; set; }

  public List<User>? TagUsers { get; set; }
}