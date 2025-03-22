
using AutoMapper;
using HighPerformance.Application.DTOs;
using HighPerformance.Domain.Entities;

namespace HighPerformance.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>();
        }
    }
}