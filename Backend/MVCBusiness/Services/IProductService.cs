using MVCModel.Models.Product;

namespace MVCBusiness.Services
{
    /// <summary>
    /// Defines the contract for product-related operations in the service layer.
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Retrieves all products from the service.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Product>> Get();
        /// <summary>
        /// Retrieves a product by its unique identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Product?> Get(int id);
    }
}
