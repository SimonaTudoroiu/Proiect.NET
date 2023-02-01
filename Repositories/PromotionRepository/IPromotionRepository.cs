using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Repositories.GenericRepository;

namespace Project_Tudoroiu_Simona_251.Repositories.PromotionRepository
{
    public interface IPromotionRepository : IGenericRepository<Promotion>
    {
        public Task<List<Promotion>> GetPromotionsWithProducts();
        public int FindDiscountByProductId(Guid productId);
        public DateTime FindFirstDayOfPromotionByProductId(Guid productId);    
        public DateTime FindLastDayOfPromotionByProductId(Guid productId);
    }
}
