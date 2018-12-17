using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoreBingNews.JsonClass
{
    public class Value
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("urlPingSuffix")]
        public string UrlPingSuffix { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("about")]
        public About[] About { get; set; }

        [JsonProperty("provider")]
        public Provider[] Provider { get; set; }

        [JsonProperty("datePublished")]
        public DateTime DataPublished { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }


        [JsonIgnore]
        private string providersName = null;
        [JsonIgnore]
        public string ProvidersName
        {
            get
            {
                if (providersName == null) providersName = Provider.Select(pr => pr.Name).Aggregate((a, b) => a + ", " + b);
                return providersName;
            }
        }
    }
}
