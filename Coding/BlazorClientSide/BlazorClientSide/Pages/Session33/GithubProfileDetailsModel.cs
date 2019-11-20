using System;

namespace BlazorClientSide.Pages.Session33
{
    public class GithubProfileDetailsModel
    {
        public string login { get; set; }
        public string name { get; set; }
        public string blog { get; set; }
        public string location { get; set; }
        public string avatar_url { get; set; }
        public string html_url { get; set; }
        public DateTime created_at { get; set; }
    }
}
