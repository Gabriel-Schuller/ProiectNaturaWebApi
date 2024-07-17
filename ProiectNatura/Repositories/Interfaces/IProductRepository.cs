using ProiectNatura.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProiectNatura.Models;

namespace ProiectNatura.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
    }
}
