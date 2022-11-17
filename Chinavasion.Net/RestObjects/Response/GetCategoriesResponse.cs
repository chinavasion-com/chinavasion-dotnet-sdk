using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Chinavasion.Net.RestObjects.Response
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class GetCategoriesResponse
    {
        [JsonPropertyName("categories")]
        public List<Category> Categories { get; set; }
    }
    public class Category
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("start_content")]
        public string? StartContent { get; set; }

        [JsonPropertyName("finish_content")]
        public string FinishContent { get; set; }

        [JsonPropertyName("subcategories")]
        public List<Subcategory>? SubCategories { get; set; }
    }

    

    public class Subcategory
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("image")]
        public string? Image { get; set; }

        [JsonPropertyName("start_content")]
        public string? StartContent { get; set; }

        [JsonPropertyName("finish_content")]
        public string? FinishContent { get; set; }

        [JsonPropertyName("subcategories")]
        public List<Subcategory>? SubCategories { get; set; }
    }
}
