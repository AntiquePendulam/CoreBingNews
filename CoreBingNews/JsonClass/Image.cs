using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoreBingNews.JsonClass
{
    [JsonObject]
    public class Image
    {
        [JsonProperty("thumbnail")]
        public _Thumbnail Thumbnail { get; set; }
        
        [JsonObject]
        public class _Thumbnail
        {
            [JsonProperty("contentUrl")]
            public string ContentUrl { get; set; }

            [JsonProperty("width")]
            public int Width { get; set; }

            [JsonProperty("height")]
            public int Height { get; set; } 
        }
    }
}
