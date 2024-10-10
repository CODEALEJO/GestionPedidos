using Microsoft.AspNetCore.Mvc;
using GestionPedidos.Models;
using GestionPedidos.Services;
using GestionPedidos.Interface;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionPedidos.Controllers.v1.Products
{
    [ApiController]
    [Route("api/v1/products")]
    [ApiExplorerSettings(GroupName = "Products")]
    public partial class ProductController : ControllerBase
    {
        protected readonly IProductInterface _productService;

        public ProductController(IProductInterface productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all products")]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        [SwaggerOperation(Summary = "Gets a product by ID", Description = "Retrieves a specific product from the database by its ID.")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound("Product not found.");
            }
            return Ok(product);
        }
    }
}
