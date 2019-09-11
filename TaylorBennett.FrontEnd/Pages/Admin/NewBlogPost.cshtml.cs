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
    public class NewBlogPostModel : PageModel
    {
        private readonly IApiClient _apiClient;

        public NewBlogPostModel(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        [BindProperty]
        public BlogPost BlogPost { get; set; }

        [TempData]
        public string Message { get; set; }
        public bool ShowMessage => !string.IsNullOrEmpty(Message);

        DateTime DateTimeNow = DateTime.Now;

        public async Task OnGetAsync(int id)
        {
            BlogPost = new BlogPost
            {
                BlogPostDate = DateTimeNow,
                Author = "Taylor Bennett"
            };
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Message = "Blog post created successfully!";

            await _apiClient.PostBlogPost(BlogPost);

            return RedirectToPage("/Blog");
        }
    }
}