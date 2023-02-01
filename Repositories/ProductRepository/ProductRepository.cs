using Microsoft.EntityFrameworkCore;
using Project_Tudoroiu_Simona_251.Data;
using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Models.Enums;
using Project_Tudoroiu_Simona_251.Repositories.GenericRepository;

namespace Project_Tudoroiu_Simona_251.Repositories.ProductRepository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ProjectContext countext) : base(countext) { }
        public async Task<List<Product>> GetProductsWithPromotions()
        {
            return await _table.Include(x => x.Promotions).ToListAsync();
        }
        public Product FindByName(string name)
        {
            return _table.FirstOrDefault(x => x.Name == name);
        }
        public string FindDescriptionByName(string name) 
        {
            return _table.FirstOrDefault(x => x.Name == name).Description;
        }
        public int FindAmountAvailableByName(string name)
        {
            return _table.FirstOrDefault(x => x.Name == name).AmountAvailable;
        }
        public async Task<List<Product>> GetProductsWithTypes(List<ProductType> types)
        {
            return await _table.Where(x => types.Contains(x.Type)).ToListAsync();
        }
        public async Task<List<Product>> GetProductsWithBeautyTypes(List<ProductTypeBeauty?> types)
        {
            return await _table.Where(x => types.Contains(x.TypeBeauty)).ToListAsync(); 
        }
    }
}
