namespace Products.API.Models
{
    public interface IDataRepository
    {
        Task AddProduct(Product product);
        Task DeleteProduct(Guid id);
        Task<Product> FindProduct(string product);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProduct(Guid id);
        Task<Product> UpdateProduct(Product product);
    }
}