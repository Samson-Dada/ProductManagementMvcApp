using ProductManagementMvcApp.Models;

namespace ProductManagementMvcApp.Data.Repositories.DataInterfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductAsync();

        Task AddProductAsync(Product product);
        Task<Product> GetProductByIdAsync(int id);
       // Task UpdateProductByIdAsync(int id);
        //Task DeleteProductByIdAsync(int id);
    }
}
