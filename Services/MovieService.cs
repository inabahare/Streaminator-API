using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using FFMpegCore;
using Streaminator.DTO.Movies;

namespace Streaminator.Services
{
  public class MovieService
  {
    readonly List<string> _movieFileType = new List<string>() { ".mp4", ".avi" };

    bool IsValidMovie(string file)
    {
      foreach (var type in _movieFileType)
        if (file.Contains(type))
          return true;

      return false;
    }

    public List<MovieCollectionDto> GetMovieCollections()
    {
      var path = "/run/media/inaba/Vids/Videos/Movies";
      var movieCollection =
        Directory
          .EnumerateFiles("/run/media/inaba/Vids/Videos/Movies", "*.*", SearchOption.AllDirectories)
          .Where(IsValidMovie)
          .Select(file =>
          {
            var probe = FFProbe.Analyse(file);
            var name = Path.GetFileName(file);

            return new MovieListingDto
            {
              Name = name,
              Path = file,
              Duration = probe.Duration.TotalMilliseconds,
            };
          })
          .Select(listing =>
          {
            var pathWithoutPath =
              listing.Path.Replace(path, "");
            var seriesName = Regex.Replace(pathWithoutPath, @"/*", "");

            return new
            {
              SeriesName = seriesName,
              MovieListing = listing
            };
          })
          .GroupBy(group => group.SeriesName)
          .Select(grouped => new MovieCollectionDto
          {
            Name = grouped.Key,
            Movies = grouped.Select(group => group.MovieListing).ToList()
          })
          .ToList();



      return movieCollection;
    }
  }
}