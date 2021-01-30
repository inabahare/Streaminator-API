using System;
using System.Collections.Generic;

namespace Models.Database
{
  public class Show
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Video> Episodes { get; set; }
  }
}