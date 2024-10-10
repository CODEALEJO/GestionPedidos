using GestionPedidos.DTOs;
using GestionPedidos.Interface;
namespace GestionPedidos.Interface;
public interface IProductInterface
{
    Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
    Task<ProductDTO> GetProductByIdAsync(int id);
    Task<ProductDTO> CreateProductAsync(ProductDTO product);
    Task<ProductDTO> UpdateProductAsync(int id, ProductDTO product);
    Task<bool> DeleteProductAsync(int id);
}
