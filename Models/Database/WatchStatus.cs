using System;

namespace Models.Database
{
    public class WatchStatus
    {
        public int Id { get; set; }
        public Video Video { get; set; }
        public int Location { get; set; }
        public DateTime Saved { get; set; }
    }
}