using System.Text.Json.Serialization;

namespace MVCModel.Models.Product
{
    /// <summary>
    /// Represents a product in the system.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Unique identifier for the product. 
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }
        /// <summary>
        /// Title of the product. 
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        /// <summary>
        /// Slug of the product, used for URL-friendly names.
        /// </summary>
        [JsonPropertyName("slug")]
        public string? Slug { get; set; }
        /// <summary>
        /// Price of the product. 
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; set; }
        /// <summary>
        /// Gets or sets the price of the item, including applicable taxes.
        /// </summary>
        [JsonPropertyName("priceWithTax")]
        public double? PriceWithTax { get; set; }
        /// <summary>
        /// Description of the product. 
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        /// <summary>
        /// Category of the product. 
        /// </summary>
        [JsonPropertyName("category")]
        public ProductCategory? Category { get; set; }
        /// <summary>
        /// List of image URLs associated with the product. 
        /// </summary>
        [JsonPropertyName("images")]
        public List<string>? Images { get; set; }
        /// <summary>
        /// Indicates whether the product was created.
        /// </summary>
        [JsonPropertyName("creationAt")]
        public DateTime CreationAt { get; set; }
        /// <summary>
        /// Indicates whether the product has been updated. 
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
