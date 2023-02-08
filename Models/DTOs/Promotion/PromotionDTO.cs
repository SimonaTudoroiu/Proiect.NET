namespace Project_Tudoroiu_Simona_251.Models.DTOs.Promotion
{
    public class PromotionDTO
    {
        public DateTime FirstDayOfPromotion { get; set; }
        public DateTime LastDayOfPromotion { get; set; }
        public int Dicount { get; set; }
        public string ProductName { get; set; }
    }
}
