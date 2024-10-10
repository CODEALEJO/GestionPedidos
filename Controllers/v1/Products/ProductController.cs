using Microsoft.AspNetCore.Mvc;
using GestionPedidos.Models;
using GestionPedidos.Services;
using GestionPedidos.DTOs; // Asegúrate de que el espacio de nombres es correcto
using Swashbuckle.AspNetCore.Annotations;
using GestionPedidos.Interface;

namespace GestionPedidos.Controllers
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
    }
}