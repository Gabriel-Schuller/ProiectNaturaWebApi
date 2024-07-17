using AutoMapper;
using ProiectNatura.DTOs;
using ProiectNatura.Models;
using ProiectNatura.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProiectNatura.DTOs;
using ProiectNatura.Models;
using ProiectNatura.Repositories.Interfaces;
using ProiectNatura.Services.Interfaces;

namespace ProiectNatura.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllProductsAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public async Task<ProductDTO> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<ProductDTO> AddProductAsync(ProductDTO productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            var newProduct = await _productRepository.AddProductAsync(product);
            return _mapper.Map<ProductDTO>(newProduct);
        }

        public async Task UpdateProductAsync(ProductDTO productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _productRepository.UpdateProductAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteProductAsync(id);
        }
    }
}
