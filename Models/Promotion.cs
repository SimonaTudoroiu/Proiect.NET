using Project_Tudoroiu_Simona_251.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Tudoroiu_Simona_251.Models
{
    public class Promotion : BaseEntity
    {
        public DateTime FirstDayOfPromotion { get; set; }
        public DateTime LastDayOfPromotion { get; set; }
        public int Dicount { get; set; }
        public Product DiscountedProduct { get; set; }
        public Guid ProductId { get; set; }
    }
}
