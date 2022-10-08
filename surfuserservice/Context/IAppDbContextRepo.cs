public interface IAppDbContextRepo
{
  public bool SaveChanges();
  
  /// <summary>
  /// 
  /// </summary>
  /// <param name="data"></param>
  /// <returns></returns>
  public void CreateUser(User data);
  public bool UpdateUser(User data);
  public bool RemoveUser(User data);
  public User GetUserByGuidId(Guid id);
  public List<User> GetUsers();

  
  public void CreateFriend(Friends data);
  public bool UpdateFriend(Friends data);
  public bool RemoveFriend(Friends data);
  public Friends GetFriend(Guid FriendshipId);
  public List<Friends> GetFriends(Guid UserId);

  public void CreateFollowing(Following data);
  public bool UpdateFollowing(Following data);
  public bool RemoveFollowing(Following data);
  public Following GetFollowing(Guid UserId, Guid FollowingId);
  public List<Following> GetFollowings(Guid UserId);

  public void CreateFollower(Followers data);
  public bool UpdateFollower(Followers data);
  public bool RemoveFollower(Followers data);
  public Followers GetFollower(Guid UserId, Guid FollowerId);
  public List<Followers> GetFollowers(Guid UserId);

}