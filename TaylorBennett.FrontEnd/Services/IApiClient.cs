using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaylorBennettDTO;

namespace TaylorBennett.FrontEnd.Services
{
    public interface IApiClient
    {
        Task<List<BlogPostResponse>> GetBlogPosts();
    }
}
