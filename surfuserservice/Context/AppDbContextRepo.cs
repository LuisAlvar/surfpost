public class AppDbContextRepo : IAppDbContextRepo
{
  private readonly AppDbContext _context;
  private readonly ILogger<AppDbContextRepo> _logger;

  public AppDbContextRepo(AppDbContext context, ILogger<AppDbContextRepo> logger)
  {
    _context = context;
    _logger = logger;
  }

  public void CreateFollower(Followers data)
  {
    try
    {
      if(_context.Followers.Where(obj => obj.UserId != data.UserId && obj.FollowerId != data.FollowerId).Any())
      {
        _context.Followers.AddAsync(data);
        _context.SaveChangesAsync();
      }
      else
      {
        throw new InvalidDataException($"Follower between {data.UserId} and {data.FollowerId} already exits");
      }
    }
    catch (System.Exception ex)
    { 
      _logger.LogError($"CreateFollower Method Error Out {ex.Message}");
    }
  }

  public void CreateFollowing(Following data)
  {
    try
    {
      if (_context.Followings
          .Where(obj => obj.UserId != data.UserId && obj.FollowingId != data.FollowingId)
          .Any())
      {
        _context.Followings.AddAsync(data);
        _context.SaveChangesAsync();
      }
      else
      {
        throw new InvalidDataException($"Following between {data.UserId} and {data.FollowingId} already exits");
      }
    }
    catch (System.Exception ex)
    { 
      _logger.LogError($"CreateFollowing Method Error out {ex.Message}");
    }
  }

  public void CreateFriend(Friends data)
  {
    try
    {
      if ( _context.Friends
            .Where(obj => obj.UserId != data.UserId && obj.FriendId != data.FriendId)
            .Any())
      {
        _context.Friends.AddAsync(data);
        _context.SaveChangesAsync();
      }
      else
      {
        throw new InvalidDataException($"Friendship between {data.UserId} and {data.FriendId} already exits");
      }
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"CreateFriend Method Error Out - {ex.Message}");
    }
  }

  public void CreateUser(User data)
  {
    try
    {
      if (_context.Users.Where(obj => obj.UserName == data.UserName).Any())
      {
        throw new InvalidDataException($"Username {data.UserName} already exist");
      }
      else{
          _context.Users.AddAsync(data);
      } 
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"CreateUser Method Error Out -  {ex.Message}");
    }
  }

  public Followers GetFollower(Guid UserId, Guid FollowerId)
  {
    Followers result = new Followers();
    try
    {
      result = _context.Followers.Where(obj => obj.UserId == UserId && obj.FollowerId == FollowerId).ToList().FirstOrDefault();  
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"GetFollower Method Error Out - {ex.Message}");
    }
    return result;
  }

  public List<Followers> GetFollowers(Guid UserId)
  {
    List<Followers> lstFollowers = new List<Followers>();
    try
    {
      lstFollowers = _context.Followers.Where(obj => obj.UserId == UserId).ToList();
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"GetFollowers Error Occur: {ex.Message}");
    }
    return lstFollowers;
  }

  public Following GetFollowing(Guid UserId, Guid FollowingId)
  {
    Following result = new Following();
    try
    {
      result = _context.Followings.Where(obj => obj.UserId == UserId && obj.FollowingId == FollowingId).ToList().FirstOrDefault();
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"GetFollowing Error Out - {ex.Message}");
    }
    return result;
  }

  public List<Following> GetFollowings(Guid UserId)
  {
    List<Following> lstFollowing = new List<Following>();
    try
    {
      lstFollowing = _context.Followings.Where(obj => obj.UserId == UserId).ToList();
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"GetFollowings Error Out - {ex.Message}");
    }
    return lstFollowing;
  }

  public Friends GetFriend(Guid FriendshipId)
  {
    Friends result = new Friends();
    try
    {
      result = _context.Friends.Where(obj => obj.FriendshipId == FriendshipId).SingleOrDefault();
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"GetFriend Error Out - {ex.Message}");
    }
    return result;
  }

  public List<Friends> GetFriends(Guid UserId)
  {
    List<Friends> lstFriends = new List<Friends>();
    try
    {
      lstFriends = _context.Friends.Where(obj => obj.UserId == UserId).ToList();
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"GetFriends Error Out - {ex.Message}");
    }
    return lstFriends;
  }

  public User GetUserByGuidId(Guid id)
  {
    User result = new User();
    try
    {
      result = _context.Users.Where(obj => obj.UserId == id).ToList().FirstOrDefault();
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"GetUser Error Out - {ex.Message}");
    }
    return result;
  }

  public List<User> GetUsers()
  {
    List<User> lstResult = new List<User>();

    try
    {
      return _context.Users.ToList();
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"GetUser List Error Out - {ex.Message}");
    }

    return lstResult;
  }

  public bool RemoveFollower(Followers data)
  {
    try
    {
      var doesExist = _context.Followers.Where(obj => obj.FollowershipId == data.FollowershipId).Any();
      if(doesExist) _context.Followers.Remove(data);
      return doesExist;
    } 
    catch (System.Exception ex)
    {
      _logger.LogError($"RemoveFollower Error Out - {ex.Message}");
      return false;
    }
  }

  public bool RemoveFollowing(Following data)
  {
    try
    {
      var doesExist = _context.Followings.Where(obj => obj.FollowingshipId == data.FollowingshipId).Any();
      if(doesExist) _context.Followings.Remove(data);
      return doesExist;
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"RemoveFollowing Error Out - {ex.Message}");
      return false;
    }
  }

  public bool RemoveFriend(Friends data)
  {
    try
    {
      var doesExist = _context.Friends.Where(obj => obj.FriendshipId == data.FriendshipId).Any();
      if(doesExist) _context.Friends.Remove(data);
      return doesExist;
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"RemoveFriend Error Out - {ex.Message}");
      return false;
    }
  }

  public bool RemoveUser(User data)
  {
    try
    {
      var doesExist = _context.Users.Where(obj => obj.UserId == data.UserId).Any();
      if(doesExist) _context.Users.Remove(data);
      return doesExist;
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"RemoveUser Error Out - {ex.Message}");
      return false;
    }
  }

  public bool SaveChanges()
  {
    return _context.SaveChanges() >= 0;
  }

  public bool UpdateFollower(Followers data)
  {
    bool didUpdate = false;
    try
    {
      Followers updateFollower = _context.Followers.Where(obj => obj.UserId == data.UserId && obj.FollowerId == data.FollowerId).FirstOrDefault();
      if( updateFollower != null)
      {
        updateFollower.Active = data.Active;
        _context.Followers.Update(updateFollower);
        _context.SaveChanges();
        didUpdate = true;
      }

      return didUpdate;
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"Update Follower Error Out - {ex.Message}");
      return didUpdate;
    }
  }

  public bool UpdateFollowing(Following data)
  {
    bool didUpdate = false;
    try
    {
      Following updateFollowing = _context.Followings.Where(obj => obj.UserId == data.UserId && obj.FollowingId == data.FollowingId).FirstOrDefault();
      if (updateFollowing != null)
      {
        updateFollowing.Active = data.Active;
        _context.Followings.Update(updateFollowing);
        _context.SaveChanges();
      }
      return didUpdate;
    }
    catch (System.Exception ex)
    {
      
      _logger.LogError($"Update Following Error Out - {ex.Message}");
      return didUpdate;
    }
  }

  public bool UpdateFriend(Friends data)
  {
    bool didUpdate = false;

    try
    {
      Friends updateFriend = _context.Friends.Where(obj => obj.UserId == data.UserId && obj.FriendId == data.FriendId).FirstOrDefault();
      if (updateFriend != null)
      {
        updateFriend.Active = data.Active;
        _context.Friends.Update(updateFriend);
        _context.SaveChanges();
        didUpdate = false;
      }

      return didUpdate;
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"Update Friends Error Out - {ex.Message}");
      return didUpdate;
    }
  }

  public bool UpdateUser(User data)
  {
    bool didUpdate = false;

    try
    {
      User updateUpdate = _context.Users.Where(obj => obj.UserId == data.UserId).FirstOrDefault();

      if(updateUpdate != null)
      {
        updateUpdate.Active = data.Active;
        updateUpdate.Image = data.Image;
        updateUpdate.LastPingLocation = data.LastPingLocation;

        _context.Users.Update(updateUpdate);
        _context.SaveChanges();
        didUpdate = true;
      }

      return didUpdate;
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"Update User Error Out - {ex.Message}");
      return didUpdate;
    }

  }

}
