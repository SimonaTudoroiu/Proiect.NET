using Project_Tudoroiu_Simona_251.Models.DTOs.Promotion;

namespace Project_Tudoroiu_Simona_251.Services.PromotionService
{
    public interface IPromotionService
    {
        public Task<List<PromotionDTO>> GetAll();
        public DateTime FindFirstDayOfPromotionByProductName(string productName);
        public DateTime FindLastDayOfPromotionByProductName(string productName);

    }
}
