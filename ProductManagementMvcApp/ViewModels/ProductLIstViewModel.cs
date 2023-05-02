using ProductManagementMvcApp.Models;

namespace ProductManagementMvcApp.ViewModels
{
    public class ProductLIstViewModel
    {
        public ProductLIstViewModel(IEnumerable<Product> products)
        {
            Products = products;
        }

        public IEnumerable<Product> Products { get; }
        
    }
}
