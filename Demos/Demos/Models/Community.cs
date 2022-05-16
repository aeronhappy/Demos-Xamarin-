using System;
using System.Collections.Generic;
using System.Text;

namespace Demos.Models
{
    public class Community
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Profile { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AdminId { get; set; }
        public string ProfileLink { get; set; }
    }
}
