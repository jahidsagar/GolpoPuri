using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolpoPuri.Library
{
    public class Story:Common
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StoryTime { get; set; }
        //uses for future banding a story
        public bool IsActive { get; set; }

        public virtual List<Comment> Comment { get; set; }
        public virtual List<Tag> Tag { get; set; }

        public virtual Categories Categories { get; set; }


    }
}
