using AutoMapper;

public class FriendProfile: Profile
{
  public FriendProfile()
  {
    CreateMap<Friends, FriendReadDto>();
    CreateMap<FriendCreateDto, Friends>();
  }

}