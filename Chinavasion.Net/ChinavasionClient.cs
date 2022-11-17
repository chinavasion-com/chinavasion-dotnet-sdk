using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;
using Chinavasion.Net.Enums;
using Chinavasion.Net.RestObjects.Response;
using Chinavasion.Net.RestObjects.Request;
using System.Collections;
using System.Text;
using System.Net.Mime;
using System.Net.Http.Json;
using System.Text.Json;

namespace Chinavasion.Net
{
    public class ChinavasionClient 
    {
        private string Key;
        public ChinavasionClient(string key)
        {
            Key = key;
        }

        /// <summary>
        /// Method to get the amount of your store credit.
        /// </summary>
        /// <returns></returns>
        public async Task<GetBalanceResponse> GetCreditBalanceAsync()
        {
            GetBalanceResponse balance = new GetBalanceResponse();
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    var query = new Dictionary<string, string>()
                    {
                        ["key"] = Key,
                    };

                    var uri = QueryHelpers.AddQueryString("/api/getCreditBalance.php", query);

                    httpClient.BaseAddress = new Uri("https://secure.chinavasion.com");
                    //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Key);

                    return await httpClient.GetFromJsonAsync<GetBalanceResponse>(uri);
                }
            }
            catch (Exception ex)
            {
            }
            return balance;
        }

        /// <summary>
        /// Price request for a list op products
        /// </summary>
        /// <param name="priceRequest"></param>
        /// <returns></returns>
        public async Task<GetPriceResponse> GetPriceAsync(GetPricesRequest priceRequest)
        {
            GetPriceResponse price = new GetPriceResponse();

            try
            {
                priceRequest.Key = Key;
                                
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://secure.chinavasion.com");

                    var response = await client.PostAsJsonAsync("/api/getPrice.php", priceRequest);
                    if (response.IsSuccessStatusCode)
                    {

                        var result = await response.Content.ReadAsStringAsync();
                        if(result.Contains("error"))
                        {
                           price.PriceError = JsonSerializer.Deserialize<ErrorResponse>(result);
                           
                        }
                        else
                        {
                            price = JsonSerializer.Deserialize<GetPriceResponse>(result);
                            
                        }
                        
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return price;

        }

        /// <summary>
        /// GetAll product categories with all subcategories
        /// </summary>
        /// <returns></returns>
        public async Task<GetCategoriesResponse> GetCategories()
        {
            GetCategoriesResponse categories = new GetCategoriesResponse();
            

            try
            {
                var query = new GetCategoriesRequest()
                {
                    Key = Key,
                    IncludeContent = 1

                };

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://secure.chinavasion.com");

                    var response = await client.PostAsJsonAsync("/api/getCategory.php", query);
                    if (response.IsSuccessStatusCode)
                    {

                        var jsonResult = await response.Content.ReadAsStringAsync();
                        categories = JsonSerializer.Deserialize<GetCategoriesResponse>(jsonResult);
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return categories;
        }
        /// <summary>
        /// GetProductDetails for a single product
        /// </summary>
        /// <param name="modelCode"></param>
        /// <returns>List details</returns>
        public async Task<GetProductDetailsResponse> GetProductDetails(string modelCode)
        {
            GetProductDetailsResponse productDetailsResponse = new GetProductDetailsResponse();


            try
            {
                var query = new Dictionary<string, string>()
                {
                    ["key"] = Key,
                    ["model_code"] = modelCode
                };

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://secure.chinavasion.com");

                    var response = await client.PostAsJsonAsync("/api/getProductDetails.php", query);
                    if (response.IsSuccessStatusCode)
                    {

                        var jsonResult = await response.Content.ReadAsStringAsync();
                        productDetailsResponse = JsonSerializer.Deserialize<GetProductDetailsResponse>(jsonResult);
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return productDetailsResponse;

        }

        /// <summary>
        /// GetProducts From queried Categories
        /// with pagination
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public async Task<GetProductsByCategoryResponse> GetProductsByCategories(GetProductsFromCategoriesRequest? query)
        {
            GetProductsByCategoryResponse? productsByCategoryResponse = new GetProductsByCategoryResponse();


            try
            {
                query.Key = Key;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://secure.chinavasion.com");

                    var response = await client.PostAsJsonAsync("/api/getProductList.php", query);
                    if (response.IsSuccessStatusCode)
                    {
                        
                        var jsonResult = await response.Content.ReadAsStringAsync();

                        
                        productsByCategoryResponse = JsonSerializer.Deserialize<GetProductsByCategoryResponse>(jsonResult);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return productsByCategoryResponse;

        }
    }


}
