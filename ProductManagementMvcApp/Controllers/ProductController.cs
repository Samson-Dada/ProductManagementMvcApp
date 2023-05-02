using Microsoft.AspNetCore.Mvc;
using ProductManagementMvcApp.Data.Repositories.DataInterfaces;
using ProductManagementMvcApp.Models;
using ProductManagementMvcApp.ViewModels;

namespace ProductManagementMvcApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IActionResult> List()
        {
            ProductLIstViewModel productLIstViewModel 
                = new (await _productRepository.GetAllProductAsync());
            return View(productLIstViewModel);
        }

        public async Task<ActionResult<Product>> Details(int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);
            if (product is null)
            {
                return NotFound();
            }
            return View(product);
        }

        public IActionResult Add()
        {

            return View();
        }

        public IActionResult Edit() {
        
        return View();
        }
    }
}
