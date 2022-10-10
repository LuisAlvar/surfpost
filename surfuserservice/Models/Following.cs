using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Following 
{
    /// <summary>
    /// Database identifer
    /// </summary>
    /// <value></value>
    [Key]
    public int Id { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
    public Guid FollowingshipId { get; set; }

    /// <summary>
    /// Primary user's mask id 
    /// </summary>
    /// <value></value>
    [Required]
    public Guid UserId { get; set; }

    /// <summary>
    /// Other user's mask id
    /// </summary>
    /// <value></value>
    [Required]
    public Guid FollowingId { get; set; }


    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [Required]
    public bool Active { get; set; }
}