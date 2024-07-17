using ProiectNatura.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProiectNatura.DTOs;

namespace ProiectNatura.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
        Task<ProductDTO> GetProductByIdAsync(int id);
        Task<ProductDTO> AddProductAsync(ProductDTO productDto);
        Task UpdateProductAsync(ProductDTO productDto);
        Task DeleteProductAsync(int id);
    }
}
