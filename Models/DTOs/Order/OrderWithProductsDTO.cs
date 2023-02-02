namespace Project_Tudoroiu_Simona_251.Models.DTOs.Order
{
    public class OrderWithProductsDTO
    {
        public DateTime PlacingDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public ICollection<ProductInOrder>? ProductInOrders { get; set; }
       
    }
}
