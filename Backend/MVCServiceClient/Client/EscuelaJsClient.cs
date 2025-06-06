using MVCModel.Models.Product;
using System.Text.Json;

namespace MVCServiceClient.Client
{
    /// <summary>
    /// EscuelaJsClient client for interacting with the EscuelaJs API.
    /// </summary>
    public class EscuelaJsClient
    {
        /// <summary>
        /// HTTP client used to make requests to the EscuelaJs API.
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Constructor for EscuelaJsClient.
        /// </summary>
        /// <param name="httpClient"></param>
        public EscuelaJsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Allows to retrieve all products from the EscuelaJs API.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Product>?> GetAllAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("/api/v1/products");

                if (!response.IsSuccessStatusCode) return null;

                var content = await response.Content.ReadAsStringAsync();
                var products = JsonSerializer.Deserialize<IEnumerable<Product>>(content);

                return products;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Allows to retrieve a product by its ID from the EscuelaJs API.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Product?> GetByIdAsync(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"/api/v1/products/{id}");

                if (!response.IsSuccessStatusCode) return null;

                var content = await response.Content.ReadAsStringAsync();
                var product = JsonSerializer.Deserialize<Product>(content);

                return product;
            }
            catch
            {
                return null;
            }
        }
    }
}
