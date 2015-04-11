using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsConsoleClient.Classes;
using Newtonsoft.Json;
using RestSharp;

namespace NewsConsoleClient
{
    public static class WebClient
    {
        private static readonly IRestClient Client;

        static WebClient()
        {
            Client = new RestClient(Utility.BaseUrl);
        }

        public static IList<Category> GetCategories()
        {
            var request = new RestRequest(Utility.CategoriesQuery, Method.GET);
            var response = Client.Execute(request);
            return JsonConvert.DeserializeObject<List<Category>>(response.Content);
        }

        public static NewsLsit GetNewsByCategoryId(int categoryId)
        {
            var request = new RestRequest(Utility.ArticlesQuery, Method.GET);
            request.AddUrlSegment("categoryId", categoryId.ToString());
            var response = Client.Execute(request);
            return JsonConvert.DeserializeObject<NewsLsit>(response.Content);
        }

        public static NewsLsit GetNewsByKeywordAndCount(string keyword, int count)
        {
            var request = new RestRequest(Utility.QueryString, Method.GET);
            request.AddUrlSegment("keyword", keyword);
            request.AddUrlSegment("count", count.ToString());
            var respons = Client.Execute(request);
            return JsonConvert.DeserializeObject<NewsLsit>(respons.Content);
        }
    }
}
