using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoreBingNews.JsonClass
{
    [JsonObject]
    public class Instrumentation
    {
        [JsonProperty("pingUrlBase")]
        public string PingUrlBase { get; set; }

        [JsonProperty("pageLoadPingUrl")]
        public string PageLoadPingUrl { get; set; }

    }
}
