using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.Linq;
using System.Collections;

namespace surfuserservice.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class SurfUserController: ControllerBase
{
  private readonly ILogger<SurfUserController> _logger;
  private readonly IMapper _mapper;

  private readonly IAppDbContextRepo _context;

  public SurfUserController(ILogger<SurfUserController> logger, IMapper mapper, IAppDbContextRepo context)
  {
    _logger = logger;
    _mapper = mapper;
    _context = context;
  }

  [HttpGet]
  public ActionResult<IEnumerable<UserReadDto>> GetUsers()
  {
    _logger.LogInformation("Called Get All Users");
    try
    {
      var result = _context.GetUsers();
      return Ok(_mapper.Map<IEnumerable<UserReadDto>>(result));
    }
    catch (System.Exception ex)
    {
      string ErrorMessage = $"Unexpected Error from GetUsers() api call - {ex.Message}";

      _logger.LogError(ErrorMessage);
      return NotFound(ErrorMessage);
    }
  }

  [HttpGet("{id}", Name="GetUser")]
  public ActionResult<UserReadDto> GetUser(Guid Id)
  {
    _logger.LogInformation($"Called Get User with Id of {Id}");
    try
    {
      var UserModel = _context.GetUserByGuidId(Id);
      if(UserModel != null) return _mapper.Map<UserReadDto>(UserModel);
      return NoContent();
    }
    catch (System.Exception ex)
    {
      _logger.LogError($"GetUser Error Out at API Call Level with - {ex.Message}");
      return NotFound();
    }
  }

  [HttpPost]
  public ActionResult<UserReadDto> CreateUser(UserCreateDto data)
  {
    _logger.LogInformation($"Called Create User");
    try
    {
      var UserModel = _mapper.Map<User>(data);
      _context.CreateUser(UserModel);
      var isSuccessful = _context.SaveChanges();
      var PublishUserModel = _mapper.Map<UserPublishDto>(UserModel);

      return CreatedAtRoute(nameof(GetUser), new {Id = UserModel.UserId}, _mapper.Map<UserReadDto>(UserModel));
    }
    catch (System.Exception ex)
    {
     _logger.LogError($"CreateUser Error Out at API Call Level  with - {ex.Message}");
      return NotFound();
    }
  }



}