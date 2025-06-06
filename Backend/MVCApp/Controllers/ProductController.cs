using Microsoft.AspNetCore.Mvc;
using MVCBusiness.Services;
using MVCModel.Models.Product;

namespace MVCApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Retrieves all products from the service.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get() 
        {
            try
            {
                var products = await _productService.Get();

                if (products == null || !products.Any())
                {
                    return NotFound("No products found.");
                }

                return Ok(products);
            }
            catch 
            {
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Retrieves a product by its unique identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id) 
        {
            try 
            {
                var product = await _productService.Get(id);

                if (product == null) 
                {
                    return NotFound($"Product with ID {id} not found.");
                }

                return Ok(product);
            }
            catch 
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
