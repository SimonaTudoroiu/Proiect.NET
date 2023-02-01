using Microsoft.EntityFrameworkCore;
using Project_Tudoroiu_Simona_251.Data;
using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Repositories.GenericRepository;

namespace Project_Tudoroiu_Simona_251.Repositories.PromotionRepository
{
    public class PromotionRepository : GenericRepository<Promotion>, IPromotionRepository
    {
        public PromotionRepository(ProjectContext context) : base(context) { }
        public async Task<List<Promotion>> GetPromotionsWithProducts()
        {
            return await _table.Include(x => x.DiscountedProduct).ToListAsync();
        }
        public int FindDiscountByProductId(Guid productId)
        {
            return _table.FirstOrDefault(x => x.ProductId == productId).Dicount;
        }
        public DateTime FindFirstDayOfPromotionByProductId(Guid productId)
        {
            return _table.FirstOrDefault(x => x.ProductId == productId).FirstDayOfPromotion;
        }
        public DateTime FindLastDayOfPromotionByProductId(Guid productId)
        {
            return _table.FirstOrDefault(x => x.ProductId == productId).LastDayOfPromotion;
        }
    }
}
