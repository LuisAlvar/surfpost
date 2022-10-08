using Microsoft.EntityFrameworkCore;

public class AppDbContext: DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) 
  {

  }

  public virtual DbSet<User> Users { get; set; }
  public virtual DbSet<Post> Posts { get; set; }

}