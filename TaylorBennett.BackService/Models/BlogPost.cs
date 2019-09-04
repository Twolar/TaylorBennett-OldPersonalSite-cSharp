using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaylorBennett.BackService.Models
{
    public class BlogPost
    {
        public int ID { get; set; }
        public string BlogPostTitle { get; set; }
        public string BlogPostBody { get; set; }
        public DateTime BlostPostDate { get; set; }
        public string Author { get; set; }
    }
}
