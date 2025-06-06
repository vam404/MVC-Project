using Microsoft.AspNetCore.Mvc;
using MVCApp.Controllers;
using MVCBusiness.Services;
using MVCModel.Models.Product;
using MVCServiceClient.Client;
using System.Text.Json;

namespace MVCTests.Controllers
{
    [TestClass]
    public sealed class ProductTest
    {
        private readonly ProductController _productController;
        private readonly IProductService _productService;
        private readonly EscuelaJsClient _escuelaJsClient;

        public ProductTest()
        {
            _escuelaJsClient = new EscuelaJsClient(new HttpClient { BaseAddress = new Uri("https://api.escuelajs.co/api/v1/") });
            _productService = new ProductService(_escuelaJsClient);
            _productController = new ProductController(_productService);
        }

        [TestMethod]
        public void TestGetAllProducts()
        {
            var result = _productController.Get().Result;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestGetProductById()
        {
            int productId = 4;
            var result = _productController.Get(productId).Result;
            Assert.IsInstanceOfType(result.Result,  typeof(OkObjectResult));
        }

        [TestMethod]
        public void TestGetProductByIdNotFound()
        {
            int productId = 1;
            var result = _productController.Get(productId).Result;
            Assert.IsInstanceOfType(result.Result, typeof(NotFoundObjectResult));
        }

        [TestMethod]
        public void TestTaxCalculation()
        {
            double price = 100.0;
            double taxRate = 0.19;

            double expectedTax = price * taxRate;

            double actualTax = ProductService.CalculateTax(price, taxRate);

            Assert.AreEqual(expectedTax, actualTax);
        }
    }
}
