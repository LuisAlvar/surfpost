using AutoMapper;

namespace surfuserservice.AutoMapper.Profiles;

public class UserProfile: Profile
{
  public UserProfile()
  {
    CreateMap<User, UserReadDto>();
    CreateMap<UserCreateDto, User>();
    CreateMap<User, UserPublishDto>();
    CreateMap<UserUpdateDto, User>();
  }
}