public class AppDbContextRepo : IAppDbContextRepo
{
  private readonly AppDbContext _Context;

  public AppDbContextRepo(AppDbContext Context)
  {
    _Context = Context;
  }

  bool IAppDbContextRepo.CreatePost(Post Post)
  {
    _Context.Posts.Add(Post);
    return _Context.SaveChanges() > 0;
  }

  bool IAppDbContextRepo.CreateUser(User User)
  {
    _Context.Users.Add(User);
    return _Context.SaveChanges() > 0;
  }

  Post? IAppDbContextRepo.GetPost(Guid PostId)
  {
    return _Context.Posts.Where(obj => obj.PostId == PostId).SingleOrDefault();
  }

  User? IAppDbContextRepo.GetUser(Guid UserId)
  {
    return _Context.Users.Where(obj => obj.UserId == UserId).SingleOrDefault();
  }

  List<Post> IAppDbContextRepo.GetUserPosts(Guid UserId)
  {
    return _Context.Posts.Where(obj => obj.User.UserId == UserId).ToList();
  }

  bool IAppDbContextRepo.SaveContext()
  {
    return _Context.SaveChanges() > 0;
  }

  bool IAppDbContextRepo.UpdatePost(Post Post)
  {
     _Context.Posts.Update(Post);
     return _Context.SaveChanges() > 0;
  }

  bool IAppDbContextRepo.UpdateUser(User User)
  {
    _Context.Users.Update(User);
    return _Context.SaveChanges() > 0;
  }
}