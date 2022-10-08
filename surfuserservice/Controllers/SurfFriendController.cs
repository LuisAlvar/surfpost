using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace surfuserservice.Controllers;


[ApiController]
[Route("/api/[controller]")]
public class SurfFriendController: ControllerBase
{
  private readonly ILogger<SurfFriendController> _logger;
  private readonly IMapper _mapper;
  private readonly IAppDbContextRepo _context;

  public SurfFriendController(ILogger<SurfFriendController> logger, IMapper mapper, IAppDbContextRepo context)
  {
    _logger = logger;
    _mapper = mapper;
    _context = context;
  }

  [HttpGet("{id}", Name="GetUser")]
  public ActionResult<FriendReadDto> GetFriend(Guid FriendshipId)
  {
    var friend = _context.GetFriend(FriendshipId);
    if (friend != null) return Ok(_mapper.Map<FriendReadDto>(friend));
    return NotFound();
  }

  [HttpGet("{id}", Name="GetFriends")]
  public ActionResult<IEnumerable<FriendReadDto>> GetFriends(Guid UserId)
  {
    var lstFriends = _context.GetFriends(UserId);
    if (lstFriends != null) return Ok(_mapper.Map<IEnumerable<FriendReadDto>>(lstFriends));
    return NotFound();
  }

  [HttpPost]
  public ActionResult<FriendReadDto> AddFriend(FriendCreateDto data)
  {
    try
    {
      var FriendModel = _mapper.Map<Friends>(data);
      _context.CreateFriend(FriendModel);
      var isSuccessful = _context.SaveChanges();
      return CreatedAtRoute(nameof(GetFriend), new {Id = FriendModel.FriendshipId}, _mapper.Map<FriendReadDto>(FriendModel));
    }
    catch (System.Exception ex) 
    {
      _logger.LogError($"AddFriend Error out at API Call Level with - {ex.Message}");
      return NotFound();
    }
  }

  [HttpDelete]
  public ActionResult RemoveFriend(FriendReadDto data)
  {
    try
    {
      var FriendModel = _mapper.Map<Friends>(data);
      var isSuccessful = _context.RemoveFriend(FriendModel);
      if(isSuccessful) return Ok();
      return NotFound();
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"RemoveFriend Error Out at API Call Level with - {ex.Message}");
      return NotFound();
    }
  }

}