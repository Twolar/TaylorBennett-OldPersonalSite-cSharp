using Microsoft.AspNetCore.Mvc;
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
        Task PostBlogPost(BlogPost blogpost);
        Task<BlogPost> GetBlogPost(int id);
        Task PutBlogPost(BlogPost blogpost);
        Task DeleteBlogPost(int id);
        Task<List<GitHubRepoResponse>> GetGitHubRepos();
    }
}
