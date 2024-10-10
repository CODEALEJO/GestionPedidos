using Microsoft.AspNetCore.Mvc;
using GestionPedidos.Services;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using GestionPedidos.Interface;

namespace GestionPedidos.Controllers.v1.Products
{
    [ApiController]
    [Route("api/v1/products")]
    [ApiExplorerSettings(GroupName = "Products")] // Agrupado por nombre
    public partial class ProductDeleteController : ControllerBase
    {
        private readonly IProductInterface _productService;

        public ProductDeleteController(IProductInterface productService)
        {
            _productService = productService;
        }

        [HttpDelete("{id:int}")]
        [SwaggerOperation(Summary = "Deletes a product by ID", Description = "Deletes a specific product by its ID.")]
        public async Task<IActionResult> Delete(int id)
        {
            var exists = await _productService.DeleteProductAsync(id);
            if (!exists)
            {
                return NotFound("Product not found.");
            }
            return NoContent();
        }
    }
}
