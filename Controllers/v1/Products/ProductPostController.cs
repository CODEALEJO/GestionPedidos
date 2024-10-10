using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestionPedidos.DTOs; // Asegúrate de que el espacio de nombres es correcto
using GestionPedidos.Services;
using Swashbuckle.AspNetCore.Annotations;
using GestionPedidos.Interface;

namespace GestionPedidos.Controllers.v1.Products
{
    [ApiController]
    [Route("api/v1/products")]
    [ApiExplorerSettings(GroupName = "Products")] // Agrupado por nombre
    public class ProductPostController : ControllerBase
    {
        private readonly IProductInterface _productService;

        public ProductPostController(IProductInterface productService)
        {
            _productService = productService;
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Creates a new product", Description = "Creates a new product in the database.")]
        public async Task<IActionResult> Create([FromBody] ProductDTO productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdProduct = await _productService.CreateProductAsync(productDto);
           return CreatedAtAction("GetById", new { id = createdProduct.Id }, createdProduct);

        }
    }
}
