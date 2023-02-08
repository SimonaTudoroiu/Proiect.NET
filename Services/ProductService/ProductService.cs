using AutoMapper;
using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Models.DTOs.Product;
using Project_Tudoroiu_Simona_251.Models.Enums;
using Project_Tudoroiu_Simona_251.Repositories.ProductRepository;

namespace Project_Tudoroiu_Simona_251.Services.ProductService
{
    public class ProductService : IProductService
    {
        public IProductRepository _productRepository;

        public IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductDTO>> GetAll()
        {
            var products = await _productRepository.GetAll();
            return _mapper.Map<List<ProductDTO>>(products);
        }

        public async Task<List<ProductDTO>> GetAllGroupedByTypes()
        {
            var products = _productRepository.GetProducts();
            return _mapper.Map<List<ProductDTO>>(products);
        }
        public async Task DeleteProductByName(string productName)
        {
            var productToDelete = _productRepository.FindByName(productName);
            _productRepository.Delete(productToDelete);
            await _productRepository.SaveAsync();
        }
        public async Task AddProduct(ProductDTO newProduct)
        {
            var newDbProduct = _mapper.Map<Product>(newProduct);
            await _productRepository.CreateAsync(newDbProduct);
            await _productRepository.SaveAsync();
        }
        public async Task<List<ProductDTO>> GetAllByTypes(List<ProductType> types)
        {
            var products = await _productRepository.GetProductsByTypes(types);
            return _mapper.Map<List<ProductDTO>>(products);
        }
        public async Task<List<ProductDTO>> GetAllByBeautyTypes(List<ProductTypeBeauty?> beautyTypes)
        {
            var products = await _productRepository.GetProductsByBeautyTypes(beautyTypes);
            return _mapper.Map<List<ProductDTO>>(products);
        }
        public async Task UpdateByName(string productName, ProductDTO product)
        {
            var productToUpdate = _productRepository.FindByName(productName);
            productToUpdate = _mapper.Map<Product>(product);
            _productRepository.Update(productToUpdate);
            await _productRepository.SaveAsync();
        }
    }
}
