﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSM_Achievers.ViewModels
{
    public class PostViewModel
    {
        public Guid? PostId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}