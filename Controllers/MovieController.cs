using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FFMpegCore;
using Streaminator.DTO;

namespace Streaminator_API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class MovieController : ControllerBase
  {
    public MovieController()
    {
    }

    readonly List<string> _movieFileType = new List<string>() { ".mp4", ".avi" };

    bool IsValidMove(string file)
    {
      foreach (var type in _movieFileType)
        if (file.Contains(type))
          return true;

      return false;
    }

    [HttpGet]
    public IActionResult Get()
    {
      var files =
        Directory
          .EnumerateFiles("/run/media/inaba/Vids/Videos/Movies", "*.*", SearchOption.AllDirectories)
          .Where(IsValidMove)
          .Select(file =>
          {
            var probe = FFProbe.Analyse(file);
            var name = Path.GetFileName(file);

            return new MovieListingDto
            {
              Name = name,
              Path = file,
              Duration = probe.Duration,
            };
          }).ToList();

      return Ok(files);
    }
  }
}
