using System;
using System.ComponentModel.DataAnnotations;

public class Post
{
  [Key]
  public int Id { get; set;}

  [Required]
  public Guid PostId { get; set; }

  [Required]
  public string? Title { get; set; }

  [Required]
  public string? Description { get; set;} 

  [Required]
  public int iLoves { get; set; }

  [Required]
  public int iViews { get; set; }

  [Required]
  public bool IsEdit { get; set; }

  [Required]
  public DateTime CreateDate { get; set; }

  [Required]
  public DateTime UpdateDate { get; set; }

  [Required]
  public User User { get; set; }

  public List<User>? TagUsers { get; set; }
}