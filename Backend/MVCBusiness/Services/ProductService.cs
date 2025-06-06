using MVCModel.Models.Product;
using MVCServiceClient.Client;

namespace MVCBusiness.Services
{
    /// <summary>
    /// Defines the contract for product-related operations in the service layer.
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly EscuelaJsClient _escuelaJsClient;

        public ProductService(EscuelaJsClient escuelaJsClient)
        {
            _escuelaJsClient = escuelaJsClient;
        }

        /// <summary>
        /// Retrieves all products from the service.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> Get()
        {
            var products = await _escuelaJsClient.GetAllAsync();
            return products ?? [];
        }

        /// <summary>
        /// Retrieves a product by its unique identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Product?> Get(int id)
        {
            var product = await _escuelaJsClient.GetByIdAsync(id);

            if (product != null) product.PriceWithTax = product.Price + CalculateTax(product.Price);

            return product ?? null;
        }

        /// <summary>
        /// Allows to calculate the tax for a given price.
        /// </summary>
        /// <param name="price"></param>
        /// <param name="taxRate"></param>
        /// <returns></returns>
        public static double CalculateTax(double price, double taxRate = 0.19)
        {
            return price * taxRate;
        }
    }
}
