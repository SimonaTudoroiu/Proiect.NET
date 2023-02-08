using Project_Tudoroiu_Simona_251.Models.DTOs.Product;
using Project_Tudoroiu_Simona_251.Models.Enums;

namespace Project_Tudoroiu_Simona_251.Services.ProductService
{
    public interface IProductService
    {
        public Task<List<ProductDTO>> GetAll();
        public Task<List<ProductDTO>> GetAllGroupedByTypes();
        public Task AddProduct(ProductDTO newProduct);
        public Task DeleteProductByName(string productName);
        public Task<List<ProductDTO>> GetAllByTypes(List<ProductType> types);
        public Task<List<ProductDTO>> GetAllByBeautyTypes(List<ProductTypeBeauty?> beautyTypes);
        public Task UpdateByName(string productName, ProductDTO product);
    }
}
