using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaylorBennett.FrontEnd.Services;
using TaylorBennettDTO;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace TaylorBennett.FrontEnd.Pages
{
    public class BlogModel : PageModel
    {
        protected readonly IApiClient _apiClient;

        [TempData]
        public string Message { get; set; }
        public bool ShowMessage => !string.IsNullOrEmpty(Message);

        public BlogModel(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public IEnumerable<BlogPost> BlogPosts { get; set; }

        public IEnumerable<BlogPost> SortedBlogPosts { get; set; }

        public bool IsAdmin { get; set; }

        public async Task OnGet()
        {
            IsAdmin = User.IsAdmin();

            var blogposts = await _apiClient.GetBlogPosts();

            SortedBlogPosts = blogposts.OrderByDescending(opt => opt.BlogPostDate).ToList();

            BlogPosts = SortedBlogPosts;
        }
    }
}