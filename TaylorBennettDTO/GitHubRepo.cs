using System;
using System.Collections.Generic;
using System.Text;

namespace TaylorBennettDTO
{
    public class GitHubRepo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string html_url { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
