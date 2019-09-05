using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaylorBennett.FrontEnd.Services;
using TaylorBennettDTO;

namespace TaylorBennett.FrontEnd.Pages
{
    public class BlogModel : PageModel
    {
        protected readonly IApiClient _apiClient;

        public BlogModel(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public IEnumerable<BlogPost> BlogPosts { get; set; }

        public async Task OnGet()
        {
            var blogposts = await _apiClient.GetBlogPosts();

            BlogPosts = blogposts;
        }
    }
}