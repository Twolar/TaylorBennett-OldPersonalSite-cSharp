using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
    }
}
