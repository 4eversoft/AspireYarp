using Microsoft.AspNetCore.Http.HttpResults;

namespace AspireYarp.ApiService.Features
{
    public static class ReadProducts
    {
        internal static async Task<Ok<IEnumerable<Product>>> Endpoint()
        {
            var products = new Products();
            return TypedResults.Ok(products.All);
        }
    }
}
