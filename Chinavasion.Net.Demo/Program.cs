
using Chinavasion.Net;
using Chinavasion.Net.Enums;
using Chinavasion.Net.RestObjects.Request;
using Chinavasion.Net.RestObjects.Response;
using Currency = Chinavasion.Net.Enums.Currency;

var api = new ChinavasionClient("your-api-key");
Console.Title = typeof(Program).Name;
Console.WriteLine("Chinavasion");

CheckBalance();
GetCategories();
GetPrice();
GetProductDetails();

GetProductsFromCategories();


async void GetPrice()
{
    var products = new List<PriceRequestProduct>();
    products.Add(new PriceRequestProduct { Quantity = 50, ModelCode = "PBY_0D6YNT90" });
    //products.Add(new PriceRequestProduct { Quantity = 50, ModelCode = "PEL_0HV7XB3C" });

    var priceRequest = await api.GetPriceAsync(new GetPricesRequest
    {
        Currency = Currency.EUR.ToString(),
        Socket = Socket.EU.ToString(),
        Products = products,
        ShippingCountryIso2 = ShippingCountry.LU.ToString(),

    });
    if (priceRequest.PriceError == null)
    {
        foreach (var product in priceRequest.Products)
        {
            Console.WriteLine("Code: {0} Id: {1} Qty: {2} Price: {3} Total: {4}", product.ModelCode, product.ProductId.ToString(), product.Quantity, product.Price, product.Total);
        }
        foreach (var shipping in priceRequest.Shipping)
        {
            Console.WriteLine("Name: {0} Delivery: {1} Price: {2}", shipping.Name, shipping.Delivery, shipping.Price);
        }
    }
    else
    {
        Console.WriteLine("Error: {0} ErrorMessage: {1} Code: {2}", priceRequest.PriceError.Error, priceRequest.PriceError.ErrorMessage, priceRequest.PriceError.Code);
    }
}
async void CheckBalance()
{
    var creditBalance = await api.GetCreditBalanceAsync();
    Console.WriteLine("Amount: {0} Currency: {1}", creditBalance.Amount, creditBalance.Currency);
}
async void GetCategories()
{
    var topCategories = await api.GetCategories();
    foreach (var Lev0Category in topCategories.Categories)
    {
        Console.WriteLine("{0}", Lev0Category.Name);

        foreach (var lev1Category in Lev0Category.SubCategories)
        {
            if (lev1Category != null)
            {
                Console.WriteLine("{0}/{1} ", Lev0Category.Name, lev1Category.Name);
                if (lev1Category.SubCategories != null)
                {
                    foreach (var lev2Category in lev1Category.SubCategories)
                    {
                        if (lev2Category != null)
                        {
                            Console.WriteLine("{0}/{1}/{2} ", Lev0Category.Name, lev1Category.Name, lev2Category.Name);
                            //if (lev2Category.SubCategories != null)
                            //{
                            //    foreach (var lev3Category in lev2Category.SubCategories)
                            //    {
                            //        if (lev3Category != null)
                            //        {
                            //            Console.WriteLine("3    Name: {0} ", lev3Category.Name);
                            //            if (lev3Category.SubCategories != null)
                            //            {
                            //                foreach (var lev4Category in lev3Category.SubCategories)
                            //                {
                            //                    if (lev4Category != null)
                            //                    {
                            //                        Console.WriteLine("4     Name: {0} ", lev4Category.Name);
                            //                    }

                            //                }
                            //            }
                            //        }

                            //    }
                            //}

                        }

                    }
                }

            }

        }
    }
}


async void GetProductDetails()
{
    var productDetails = await api.GetProductDetails("PBY_0D6YNT90");

    var product = productDetails.Products.FirstOrDefault();
    Console.WriteLine("Fullname: {0} Price: {1}", product.FullProductName, product.Price);
}

async void GetProductsFromCategories()
{
    var query = new List<GetProductsFromCategoriesRequest>();

    
    var getProductsByCategoryResponse = await api.GetProductsByCategories(new GetProductsFromCategoriesRequest()
    {
       
        Currency = Currency.EUR.ToString(),
        Pagination = new GetProductsFromCategoriesRequestPagination()
        {
            Start = 0,
            Count = 25
        },
        Categories = new string[] { "Kitchen Appliances" },
        PriceLevel = null
    });

    

    foreach (var product in getProductsByCategoryResponse.Products)
    {
        Console.WriteLine("Code: {0} Id: {1} EAN: {2} Price: {3} Status: {4} Weight: {5}", product.ModelCode, product.ProductId, product.Ean, product.Price, product.Status, product.Package.WeightKg);
    }

}
    

Console.ReadKey();

