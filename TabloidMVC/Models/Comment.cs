﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TabloidMVC.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserProfileId { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public bool CurrentUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public UserProfile UserProfile { get; set; }

    }
}
