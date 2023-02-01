namespace Project_Tudoroiu_Simona_251.Models
{
    public class ProductInOrder
    {
        public Product Product { get; set; }
        public Guid ProductId { get; set; }
        public Order Order { get; set; }
        public Guid OrderId { get; set; }
    }
}
