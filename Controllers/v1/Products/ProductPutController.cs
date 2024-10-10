using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using GestionPedidos.DTOs;
using GestionPedidos.Interface;

namespace GestionPedidos.Controllers.v1.Products
{
    [ApiController]
    [Route("api/v1/products")]
    [ApiExplorerSettings(GroupName = "Products")] // Agrupado por nombre
    public class ProductPutController : ControllerBase
    {
        private readonly IProductInterface _productService;

        public ProductPutController(IProductInterface productService)
        {
            _productService = productService;
        }

        [HttpPut("{id:int}")]
        [SwaggerOperation(Summary = "Updates an existing product", Description = "Updates an existing product in the database by its ID.")]
        public async Task<IActionResult> Update(int id, [FromBody] ProductDTO productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedProduct = await _productService.UpdateProductAsync(id, productDto);
            if (updatedProduct == null)
            {
                return NotFound("Product not found.");
            }

            return Ok(updatedProduct);
        }

    }
}
