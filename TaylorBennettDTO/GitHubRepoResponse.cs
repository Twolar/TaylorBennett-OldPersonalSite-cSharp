using System;
using System.Collections.Generic;
using System.Text;

namespace TaylorBennettDTO
{
    public class GitHubRepoResponse : GitHubRepo
    {
        public ICollection<GitHubRepo> GitHubRepos { get; set; } = new List<GitHubRepo>();
    }
}
