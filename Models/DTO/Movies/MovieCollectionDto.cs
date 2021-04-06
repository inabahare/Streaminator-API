using System;
using System.Collections.Generic;

namespace Streaminator.DTO.Movies
{
  public class MovieCollectionDto
  {
    public string Name { get; set; }
    public List<MovieListingDto> Movies { get; set; }
  }
}