using System.Text.Json.Serialization;

namespace MVCModel.Models.Product
{
    /// <summary>
    /// Represents a product category in the system. 
    /// </summary>
    public class ProductCategory
    {
        /// <summary>
        /// Id of the product category.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
        /// <summary>
        /// Name of the product category.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        /// <summary>
        /// Slug of the product category, used for URL-friendly names.
        /// </summary>
        [JsonPropertyName("slug")]
        public string? Slug { get; set; }
        /// <summary>
        /// Image URL for the product category.
        /// </summary>
        [JsonPropertyName("image")]
        public string? Image { get; set; }
        /// <summary>
        /// Creation date of the product category.
        /// </summary>
        [JsonPropertyName("creationAt")]
        public DateTime CreationAt { get; set; }
        /// <summary>
        /// Last updated date of the product category. 
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
