public interface IAppDbContextRepo
{
  public bool SaveContext();
  public Post? GetPost(Guid PostId);
  public List<Post>? GetUserPosts(Guid UserId);
  public bool CreatePost(Post Post);
  public bool UpdatePost(Post Post);

  public User? GetUser(Guid UserId);
  public bool CreateUser(User User);
  public bool UpdateUser(User User);
  
}