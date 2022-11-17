using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Chinavasion.Net.RestObjects.Request
{
    public  class GetCategoriesRequest
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }
        
        [JsonPropertyName("include_content")]
        public int IncludeContent { get; set; }
    }
}
