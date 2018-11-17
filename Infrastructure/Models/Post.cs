using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSM_Achievers.Infrastructure.Models
{
    public class Post
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

        public string TemplateName { get; set; }

        public bool IsPublished { get; set; }

        public DateTime PostExpiry { get; set; }
    }
}