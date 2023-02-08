using Project_Tudoroiu_Simona_251.Models.Enums;

namespace Project_Tudoroiu_Simona_251.Models.DTOs.Product
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public int AmountAvailable { get; set; }
        public string DominantColor { get; set; }
        public ProductType Type { get; set; }
        public ProductTypeBeauty? TypeBeauty { get; set; }
    }
}

