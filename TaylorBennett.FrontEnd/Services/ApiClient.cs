using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TaylorBennettDTO;

namespace TaylorBennett.FrontEnd.Services
{
    public class ApiClient : IApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<BlogPostResponse>> GetBlogPosts()
        {
            var response = await _httpClient.GetAsync("/api/BlogPosts");

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<List<BlogPostResponse>>();
        }

        public async Task PostBlogPost(BlogPost blogpost)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/BlogPosts/", blogpost);

            response.EnsureSuccessStatusCode();
        }

        public async Task<BlogPost> GetBlogPost(int id)
        {
            var response = await _httpClient.GetAsync($"/api/BlogPosts/{id}");

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<BlogPostResponse>();
        }

        public async Task PutBlogPost(BlogPost blogpost)
        {
            var response = await _httpClient.PutAsJsonAsync($"/api/BlogPosts/{blogpost.ID}", blogpost);

            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteBlogPost(int id)
        {
            var response = await _httpClient.DeleteAsync($"/api/BlogPosts/{id}");

            if(response.StatusCode == HttpStatusCode.NotFound)
            {
                return;     
            }

            response.EnsureSuccessStatusCode();
        }

        public async Task<List<GitHubRepoResponse>> GetGitHubRepos()
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Taylor Bennett");


            var response = await _httpClient.GetAsync("https://api.github.com/users/twolar/repos");

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<List<GitHubRepoResponse>>();
        }

        public async Task<string> GetGitHubRepoReadMe(string githubreponame)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/octet-stream"));
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Taylor Bennett");

            string url = "https://raw.githubusercontent.com/twolar/" + githubreponame + "/master/README.md";

            var response = await _httpClient.GetAsync(url);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
