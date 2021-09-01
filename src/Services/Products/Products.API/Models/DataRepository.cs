
namespace Products.API.Models;
public class DataRepository : IDataRepository
{
    private ApiDbContext _context;

    public DataRepository(ApiDbContext context)
    {
        _context = context;
    }

    public async Task AddProduct(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProduct(Guid id)
    {
        var itemToRemove = await _context.Products.FindAsync(id);
        if (itemToRemove == null)
            throw new NullReferenceException();

        _context.Products.Remove(itemToRemove);
        await _context.SaveChangesAsync();
    }

    public async Task<Product> GetProduct(Guid id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task<Product> FindProduct(string product)
    {
        return await _context.Products.FirstOrDefaultAsync(x => x.Name == product);
    }

    public async Task<Product> UpdateProduct(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
        return await _context.Products.Where(x => x.Id == product.Id).SingleOrDefaultAsync();
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        return await _context.Products.ToListAsync();
    }
}
