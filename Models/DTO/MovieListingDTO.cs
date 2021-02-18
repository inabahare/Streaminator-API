using System;

namespace Streaminator.DTO
{
  public class MovieListingDto
  {
    public string Name { get; set; }
    public string Path { get; set; }
    public TimeSpan Duration { get; set; }
  }
}