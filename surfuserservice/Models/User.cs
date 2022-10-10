using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
  [Key]
  public int Id { get; set; }

  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public Guid UserId { get; set; }

  [Required]
  public string Name { get; set; }

  [Required]
  public byte[] Image { get; set; }

  [Required]
  public string UserName { get; set; }

  [Required]
  public string UserLocation { get; set; }

  [Required]
  public bool Active { get; set; }

  [Required]
  public DateTime LastActive { get; set; }

  [Required]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public DateTime CreateDate { get; set; }

  [Required]
  [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
  public DateTime LastUpdateDate { get; set; }

  [Required]
  public string LastPingLocation { get; set; }
}