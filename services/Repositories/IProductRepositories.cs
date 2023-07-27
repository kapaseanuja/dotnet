using services.Entity;

namespace services.Repositories;

public interface IProductRepositories
{
    Task<IEnumerable<Product>> GetProducts();
    Task<Product> GetProduct(string id);
     Task<IEnumerable<Product>> GetProductName(string name);
     Task<IEnumerable<Product>> GetProductByCategory(string categoryName);

     Task CreateProduct(Product product);
     Task<bool> UpdateProduct(Product product);
     Task<bool> DeleteProduct(string id);
}
