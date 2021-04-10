using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FFMpegCore;
using Streaminator.DTO.Movies;
using Streaminator.Services;

namespace Streaminator_API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class MovieController : ControllerBase
  {
    readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
      _movieService = movieService;
    }


    [HttpGet]
    public IActionResult Get()
    {
      var movies = _movieService.GetMovieCollections();

      return Ok(movies);
    }
  }
}
