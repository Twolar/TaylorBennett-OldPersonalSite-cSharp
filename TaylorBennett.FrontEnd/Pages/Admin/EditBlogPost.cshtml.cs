using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaylorBennett.FrontEnd.Services;
using TaylorBennettDTO;

namespace TaylorBennett.FrontEnd.Pages.Admin
{
    public class EditBlogPostModel : PageModel
    {
        private readonly IApiClient _apiClient;

        public EditBlogPostModel(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        [BindProperty]
        public BlogPost BlogPost { get; set; }

        [TempData]
        public string Message { get; set; }
        public bool ShowMessage => !string.IsNullOrEmpty(Message);

        public async Task OnGetAsync(int id)
        {
            var blogpost = await _apiClient.GetBlogPost(id);
            BlogPost = new BlogPost
            {
                ID = blogpost.ID,
                BlogPostTitle = blogpost.BlogPostTitle,
                BlogPostBody = blogpost.BlogPostBody,
                BlogPostDate = blogpost.BlogPostDate,
                Author = blogpost.Author
            };
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Message = "Blog post updated successfully!";

            await _apiClient.PutBlogPost(BlogPost);

            return Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var session = await _apiClient.GetBlogPost(id);

            if (session != null)
            {
                await _apiClient.DeleteBlogPost(id);
            }

            Message = "Blog post deleted successfully!";

            return RedirectToPage("/Blog");
        }
    }
}