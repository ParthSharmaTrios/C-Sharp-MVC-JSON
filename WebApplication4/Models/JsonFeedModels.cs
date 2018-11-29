using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class JsonFeedModels
    {
        public int albumId { get; set; }
        public int Id { get; set; }

        public string title { get; set; }

        public string url { get; set; }

        public string thumbnailUrl { get; set; }
    }
}