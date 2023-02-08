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
        public  List<Product> GetProductsWithPromotions()
        {
            return  _table.Include(x => x.Promotions).GroupBy(x => x.Type).SelectMany(obj => obj).ToList();
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
        public async Task<List<Product>> GetProductsByTypes(List<ProductType> types)
        {
            return await _table.Where(x => types.Contains(x.Type)).OrderBy(x => x.AmountAvailable).ToListAsync();
        }
        public async Task<List<Product>> GetProductsByBeautyTypes(List<ProductTypeBeauty?> types)
        {
            return await _table.Where(x => types.Contains(x.TypeBeauty)).OrderBy(x => x.AmountAvailable).ToListAsync(); 
        }
    }
}
