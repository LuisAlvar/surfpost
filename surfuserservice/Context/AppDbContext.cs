using Microsoft.EntityFrameworkCore;

public class AppDbContext: DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
  {

  }

  public virtual DbSet<User> Users { get; set; }
  public virtual DbSet<Friends> Friends { get; set; }
  public virtual DbSet<Following> Followings { get; set; }
  public virtual DbSet<Followers> Followers { get; set; }
  
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<User>().Property(obj => obj.UserId).HasDefaultValue(Guid.NewGuid());
    modelBuilder.Entity<Friends>().Property(obj => obj.FriendshipId).HasDefaultValue(Guid.NewGuid());
    modelBuilder.Entity<Following>().Property(obj => obj.FollowingshipId).HasDefaultValue(Guid.NewGuid());
    modelBuilder.Entity<Followers>().Property(obj => obj.FollowershipId).HasDefaultValue(Guid.NewGuid());
  }

}