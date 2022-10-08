using AutoMapper;

public class PostProfile: Profile
{
  public PostProfile()
  {
    //Source -> Target 
    CreateMap<Post, PostReadDto>();
    CreateMap<PostCreateDto, Post>();
    CreateMap<PostUpdateDto, Post>();
  }
}