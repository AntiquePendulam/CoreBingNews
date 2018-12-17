using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json;
using CoreBingNews.JsonClass;

namespace CoreBingNews
{
    public static class NewsSearch
    {
        internal static HttpClient Client { get; set; } = new HttpClient() { BaseAddress = new Uri("https://api.cognitive.microsoft.com/bing/v7.0/news/") };

        public static SearchSession SetSubscriptionKey(string key)
        {
            Client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", key);
            return new SearchSession(key);
        }

        public class SearchSession
        {
            public static string Key { get; private set; }

            public SearchSession(string key)
            {
                Key = key;
            }
            public async Task<News> NewsSearch(Dictionary<string,object> keys)
            {
                var array = keys.Select(key => $"{key.Key}={key.Value.ToString()}").ToArray();
                var query = String.Join("&", array);
                var message = await Client.GetAsync("search?" + query);
                return await GetNewsAsync(message);
            }

            public async Task<News> CategoryNews(string mkt = "en-us")
            {
                var message = await Client.GetAsync($"?mkt={mkt}");
                return await GetNewsAsync(message);
            }
            public async Task<News> CategoryNews(string category, string mkt="en-us")
            {
                var message = await Client.GetAsync($"?Category={category}&mkt={mkt}");
                return await GetNewsAsync(message);
            }

            private async Task<News> GetNewsAsync(HttpResponseMessage message)
            {
                var response = await message.Content.ReadAsStringAsync();
                Console.WriteLine(response);
                var Result = JsonConvert.DeserializeObject<News>(response);
                return Result;
            }
        }
    }
}