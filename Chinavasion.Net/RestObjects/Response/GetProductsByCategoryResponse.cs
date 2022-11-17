using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Chinavasion.Net.RestObjects.Response
{
    
    public class Pagination
    {
        [JsonPropertyName("start")]
        public int? Start { get; set; }

        [JsonPropertyName("count")]
        public int? Count { get; set; }

        [JsonPropertyName("total")]
        public int? Total { get; set; }

    }


    public class GetProductsByCategoryResponse
    {
        [JsonPropertyName("products")]
        public List<Product>? Products { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination? Pagination { get; set; }


    }

    public class Special
    {
        [JsonPropertyName("normal_price")]
        public string? NormalPrice { get; set; }

        [JsonPropertyName("discount")]
        public string? Discount { get; set; }

        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

    }
    

    public class Product
    {
        [JsonPropertyName("product_id")]
        public int? ProductId { get; set; }

        [JsonPropertyName("model_code")]
        public string? ModelCode { get; set; }

        [JsonPropertyName("full_product_name")]
        public string? FullProductName { get; set; }

        [JsonPropertyName("short_product_name")]
        public string? ShortProductName { get; set; }

        [JsonPropertyName("product_url")]
        public string? ProductUrl { get; set; }

        [JsonPropertyName("category_name")]
        public string? CategoryName { get; set; }

        [JsonPropertyName("category_url")]
        public string? CategoryUrl { get; set; }

        [JsonPropertyName("subcategory_name")]
        public string? SubcategoryName { get; set; }

        [JsonPropertyName("subcategory_url")]
        public string? SubcategoryUrl { get; set; }

        [JsonPropertyName("date_product_was_launched")]
        public string? DateProductWasLaunched { get; set; }

        [JsonPropertyName("main_picture")]
        public string? MainPicture { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }

        [JsonPropertyName("price")]
        public string? Price { get; set; }

        [JsonPropertyName("retail_price")]
        public string? RetailPrice { get; set; }

        [JsonPropertyName("ean")]
        public object? Ean { get; set; }

        [JsonPropertyName("continuity")]
        public string? Continuity { get; set; }

        [JsonPropertyName("overview")]
        public string? Overview { get; set; }

        [JsonPropertyName("specification")]
        public string? Specification { get; set; }

        [JsonPropertyName("additional_images")]
        public List<string>? AdditionalImages { get; set; }

        [JsonPropertyName("package")]
        public Package? Package { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("meta_keyword")]
        public string? MetaKeyword { get; set; }

        [JsonPropertyName("meta_description")]
        public string? MetaDescription { get; set; }

        [JsonPropertyName("special")]
        public Special? Special { get; set; }
    }
    public class Package
    {
        [JsonPropertyName("weight_kg")]
        public object? WeightKg { get; set; }

        [JsonPropertyName("height_mm")]
        public object? HeightMm { get; set; }

        [JsonPropertyName("width_mm")]
        public object? WidthMm { get; set; }

        [JsonPropertyName("depth_mm")]
        public object? DepthMm { get; set; }

        [JsonPropertyName("height_cm")]
        public object? HeightCm { get; set; }

        [JsonPropertyName("width_cm")]
        public object? WidthCm { get; set; }

        [JsonPropertyName("depth_cm")]
        public object? DepthCm { get; set; }
    }
}
