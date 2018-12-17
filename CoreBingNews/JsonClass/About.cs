using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoreBingNews.JsonClass
{
    [JsonObject]
    public class About
    {
        [JsonProperty("readLink")]
        public string ReadLink { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
