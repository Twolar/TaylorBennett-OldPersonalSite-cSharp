using System;
using System.Collections.Generic;
using System.Text;

namespace TaylorBennettDTO
{
    public class BlogPostResponse : BlogPost
    {
        public ICollection<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
    }
}
