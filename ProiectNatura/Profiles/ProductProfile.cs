using AutoMapper;
using ProiectNatura.DTOs;
using ProiectNatura.Models;

namespace ProiectNatura.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
