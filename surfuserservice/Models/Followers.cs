using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Followers
{
  /// <summary>
  /// Database 
  /// </summary>
  /// <value></value>
  [Key]
  public int Id { get; set; }

  /// <summary>
  /// 
  /// </summary>
  /// <value></value>
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public Guid FollowershipId { get; set; }

  /// <summary>
  /// The primary user - mask id - 
  /// </summary>
  /// <value></value>
  [Required]
  public Guid UserId { get; set; }

  /// <summary>
  /// Other user's mask id 
  /// </summary>
  /// <value></value>
  [Required]
  public Guid FollowerId { get; set; }

  /// <summary>
  /// 
  /// </summary>
  /// <value></value>
  [Required]
  public bool Active { get; set; }
}