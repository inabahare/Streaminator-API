using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FFMpegCore;
using Streaminator.DTO.Movies;

namespace Streaminator_API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class MovieController : ControllerBase
  {
    public MovieController()
    {
    }


    [HttpGet]
    public IActionResult Get()
    {


      return Ok(files);
    }
  }
}
