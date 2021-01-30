using System;

namespace Models.Database
{
  public class Video
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Path { get; set; }
    public int Duration { get; set; }
    public int REL_Video { get; set; }
  }
}