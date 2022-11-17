using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Chinavasion.Net.RestObjects.Request
{
    public class GetProductsFromCategoriesRequest
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("categories")]
        public Array Categories { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("pagination")]
        public GetProductsFromCategoriesRequestPagination Pagination { get; set; }

        [JsonPropertyName("price_level")]
        public int? PriceLevel { get; set; }
    }

    public class GetProductsFromCategoriesRequestPagination
    {
        [JsonPropertyName("start")]
        public int Start { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
