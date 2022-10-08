
using Microsoft.AspNetCore.Mvc;

namespace surfpostservice.Controllers;

[ApiController]
[Route("api/spost")]
public class SurfingPostController: ControllerBase
{
  private readonly ILogger<SurfingPostController> _Logger;

  public SurfingPostController(ILogger<SurfingPostController> Logger)
  {
    _Logger = Logger;
  } 

  //[HttpGet(Name = "GetWeatherForecast")]

}