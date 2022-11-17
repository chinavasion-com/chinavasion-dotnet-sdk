using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Chinavasion.Net.RestObjects.Response
{
    /// <summary>
    /// ProductDetailsResponse
    /// </summary>
    public class GetProductDetailsResponse 
    {
        [JsonPropertyName("products")]
        public List<ProductDetails> Products { get; set; }
    }

    public class ProductDetailsPackage
    {
        [JsonPropertyName("weight_kg")]
        public double WeightKg { get; set; }

        [JsonPropertyName("height_mm")]
        public int HeightMm { get; set; }

        [JsonPropertyName("width_mm")]
        public int WidthMm { get; set; }

        [JsonPropertyName("depth_mm")]
        public int DepthMm { get; set; }

        [JsonPropertyName("height_cm")]
        public int HeightCm { get; set; }

        [JsonPropertyName("width_cm")]
        public int WidthCm { get; set; }

        [JsonPropertyName("depth_cm")]
        public int DepthCm { get; set; }


    }

    public class ProductDetails
    {
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }

        [JsonPropertyName("model_code")]
        public string ModelCode { get; set; }

        [JsonPropertyName("full_product_name")]
        public string FullProductName { get; set; }

        [JsonPropertyName("short_product_name")]
        public string ShortProductName { get; set; }

        [JsonPropertyName("product_url")]
        public string ProductUrl { get; set; }

        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        [JsonPropertyName("category_url")]
        public string CategoryUrl { get; set; }

        [JsonPropertyName("subcategory_name")]
        public string SubcategoryName { get; set; }

        [JsonPropertyName("subcategory_url")]
        public string SubcategoryUrl { get; set; }

        [JsonPropertyName("date_product_was_launched")]
        public string DateProductWasLaunched { get; set; }

        [JsonPropertyName("main_picture")]
        public string MainPicture { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("retail_price")]
        public string RetailPrice { get; set; }

        [JsonPropertyName("ean")]
        public int Ean { get; set; }

        [JsonPropertyName("continuity")]
        public string Continuity { get; set; }

        [JsonPropertyName("overview")]
        public string Overview { get; set; }

        [JsonPropertyName("specification")]
        public string Specification { get; set; }

        [JsonPropertyName("additional_images")]
        public List<string> AdditionalImages { get; set; }

        [JsonPropertyName("package")]
        public Package Package { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("meta_keyword")]
        public string MetaKeyword { get; set; }

        [JsonPropertyName("meta_description")]
        public string MetaDescription { get; set; }
    }


}
