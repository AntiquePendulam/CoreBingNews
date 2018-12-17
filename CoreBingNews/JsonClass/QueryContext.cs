using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoreBingNews.JsonClass
{
    [JsonObject]
    public class QueryContext
    {
        [JsonProperty("originalQuery")]
        public string OriginalQuery { get; set; }
        [JsonProperty("adultIntent")]
        public bool AdultIntent { get; set; }
    }
}
