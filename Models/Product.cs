using Project_Tudoroiu_Simona_251.Models.Base;
using Project_Tudoroiu_Simona_251.Models.Enums;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Tudoroiu_Simona_251.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public int AmountAvailable { get; set; }
        public string DominantColor { get; set; }
        public ProductType Type { get; set; }
        public ProductTypeBeauty? TypeBeauty { get; set; }
        public ICollection<Promotion>? Promotions { get; set; }
        public ICollection<ProductInOrder>? ProductInOrders { get; set; }
    }
}
