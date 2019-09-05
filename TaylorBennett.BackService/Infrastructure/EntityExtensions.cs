using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaylorBennett.BackService.Models;

namespace TaylorBennett.BackService.Infrastructure
{
    public static class EntityExtensions
    {
        public static TaylorBennettDTO.BlogPostResponse MapBlogPostResponse(this BlogPost blogPost) =>
            new TaylorBennettDTO.BlogPostResponse
            {
                ID = blogPost.ID,
                BlogPostTitle = blogPost.BlogPostTitle,
                BlogPostBody = blogPost.BlogPostBody,
                BlogPostDate = blogPost.BlogPostDate,
                Author = blogPost.Author
            };
    }
}
