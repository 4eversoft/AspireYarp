namespace AspireYarp.ApiService.Features
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Product() { }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
