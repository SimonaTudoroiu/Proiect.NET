using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Models.Enums;
using Project_Tudoroiu_Simona_251.Repositories.GenericRepository;
using System.Globalization;

namespace Project_Tudoroiu_Simona_251.Repositories.ProductRepository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public List<Product> GetProductsWithPromotions();
        public Product FindByName(string name);
        public string FindDescriptionByName(string name);
        public int FindAmountAvailableByName(string name);
        public Task<List<Product>> GetProductsByTypes(List<ProductType> types);
        public Task<List<Product>> GetProductsByBeautyTypes(List<ProductTypeBeauty?> types);

    }
}
