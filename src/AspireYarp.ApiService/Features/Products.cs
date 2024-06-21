namespace AspireYarp.ApiService.Features
{
    public class Products
    {
        private readonly List<Product> products =
        [
            new Product(1, "Product 1"),
            new Product(2, "Product 2")
        ];

        public IEnumerable<Product> All => products;

        public Product this[int index] => products[index];
    }
}
