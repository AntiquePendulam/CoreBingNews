using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CoreBingNews.JsonClass;

namespace CoreBingNews
{
    [JsonObject]
    public class News
    {
        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("instrumentation")]
        public Instrumentation Instrumentation { get; set; }

        [JsonProperty("readLink")]
        public string ReadLink { get; set; }

        [JsonProperty("queryContext")]
        public QueryContext QueryContext { get; set; }

        [JsonProperty("totalEstimatedMatches")]
        public int TotalEstimatedMatches { get; set; }

        [JsonProperty("sort")]
        public Sort[] Sort { get; set; }

        [JsonProperty("value")]
        public Value[] Value { get; set; }
    }
}
