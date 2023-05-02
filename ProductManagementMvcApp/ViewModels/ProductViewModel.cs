using ProductManagementMvcApp.Models;

namespace ProductManagementMvcApp.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel(Product product)
        {
            Product= product;
        }

        public Product Product { get; set; }
    }
}
