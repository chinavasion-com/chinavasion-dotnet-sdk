using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;

namespace Chinavasion.Net.RestObjects.Request
{
    public class GetPricesRequest
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("socket")]
        public string Socket { get; set; }

        [JsonPropertyName("products")]
        public List<PriceRequestProduct> Products { get; set; }

        [JsonPropertyName("shipping_country_iso2")]
        public string ShippingCountryIso2 { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
    public class PriceRequestProduct
    {
        [JsonPropertyName("model_code")]
        public string ModelCode { get; set; }

        [JsonPropertyName("product_id")]
        public int? ProductId { get; set; } = null;

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; } 

        [JsonPropertyName("price_level")]
        public int? PriceLevel { get; set; } = null;
    }
}
