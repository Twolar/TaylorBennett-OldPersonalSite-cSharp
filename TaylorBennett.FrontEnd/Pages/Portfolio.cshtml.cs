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
using System.Diagnostics;

namespace TaylorBennett.FrontEnd.Pages
{
    public class PortfolioModel : PageModel
    {
        string GitHubRepoName;
        protected readonly IApiClient _apiClient;
 
        public PortfolioModel(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public IEnumerable<GitHubRepo> GitHubRepos { get; set; }

        public IEnumerable<GitHubRepo> SortedGitHubRepos { get; set; }

        public async Task OnGet()
        {

            var githubrepos= await _apiClient.GetGitHubRepos();


            SortedGitHubRepos = githubrepos.OrderByDescending(opt => opt.updated_at).ToList();

            GitHubRepos = SortedGitHubRepos;

            // Get Github repo README.md 's
            
            foreach(var githubrepo in GitHubRepos)
            {
                GitHubRepoName = githubrepo.name;

                var githubreporeadme = await _apiClient.GetGitHubRepoReadMe(GitHubRepoName);

                githubrepo.ReadMeContent = githubreporeadme;
            }
        }   
    }
}
