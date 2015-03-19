using System.Collections.Generic;

namespace UntappedWidgetGenerator.Model
{
    public class WidgetViewModel
    {
        public string Info { get; set; }
        public string Username { get; set; }
        public string AvatarUrl { get; set; }
        public string HeaderBackgroundUrl { get; set; }
        public ICollection<Badge> Badges { get; set; } 
    }
}
