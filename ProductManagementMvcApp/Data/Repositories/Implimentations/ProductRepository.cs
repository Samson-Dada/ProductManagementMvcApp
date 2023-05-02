using Microsoft.EntityFrameworkCore;
using ProductManagementMvcApp.Data.Repositories.DataInterfaces;
using ProductManagementMvcApp.Models;

namespace ProductManagementMvcApp.Data.Repositories.DataImplimentations
{
    
    public class ProductRepository : IProductRepository
    {
        private readonly WebAppDbContext _dbContext;
        public ProductRepository(WebAppDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException("Not found", nameof(_dbContext));
        }

        public async Task AddProductAsync(Product product)
        {
             await _dbContext.Products.AddAsync(product);
        }

        public async Task<IEnumerable<Product>> GetAllProductAsync()
        {
            var getAllProduct = await _dbContext.Products.ToListAsync();
            return getAllProduct;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
          var product =   await _dbContext.Products.SingleOrDefaultAsync(p => p.Id == id);
           
            return product?.Id != null ? product: null;
        }

        //change reimplement the method, after sorting 
        /*
         var product = await _dbContext.Products
    .Include(p => p.Category)
    .SingleOrDefaultAsync(p => p.Id == id);

         */
    }
}
