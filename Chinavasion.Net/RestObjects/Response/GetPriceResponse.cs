using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Chinavasion.Net.RestObjects.Response
{
    public class GetPriceResponse
    {
        [JsonPropertyName("products")]
        public List<ResponseProduct>? Products { get; set; }

        [JsonPropertyName("currency")]
        public Currency? Currency { get; set; }

        [JsonPropertyName("shipping")]
        public List<Shipping>? Shipping { get; set; }

        [JsonPropertyName("Error")]
        public ErrorResponse PriceError { get; set; }
        

    }
    public class ResponseProduct
    {
        [JsonPropertyName("product_id")]
        public int? ProductId { get; set; }

        [JsonPropertyName("model_code")]
        public string ModelCode { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("price")]
        public string? Price { get; set; }

        [JsonPropertyName("total")]
        public string? Total { get; set; }

        [JsonPropertyName("retail_price")]
        public string? RetailPrice { get; set; }

    }
    public class Currency
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        [JsonPropertyName("postfix")]
        public string? Postfix { get; set; }

    }

    public class Shipping
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("price")]
        public string? Price { get; set; }

        [JsonPropertyName("delivery")]
        public string? Delivery { get; set; }
    }
    
    //public class PriceError
    //{
    //    [JsonPropertyName("error")]
    //    public string Error { get; set; }

    //    [JsonPropertyName("error_message")]
    //    public string ErrorMessage { get; set; }

    //    [JsonPropertyName("code")]
    //    public int Code { get; set; }
    //}
}
