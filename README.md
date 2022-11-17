
<p align="center">
    <a href="https://www.terrarebels.net/"><img src="https://learn.microsoft.com/en-us/windows/images/csharp-logo.png" align="center" width=150/></a>
</p>

<p align="center">
C# SDK to consume Chinavasion.com's wholesaler API
</p>
<br/>

## Usage

Chinavasion.Net sdk can be used for .Net core Web and WPF applications


GetCreditBalance
```cs

async void GetCreditBalance() 
{
    
    var api = new ChinavasionClient("your-api-key");
    
    var creditBalance = await api.GetCreditBalanceAsync();
    Console.WriteLine("Amount: {0} Currency: {1}", creditBalance.Amount, creditBalance.Currency);
}

```

GetProductsFromCategories
```cs
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
```

...for more examples see Demo

Todo's: create orders
