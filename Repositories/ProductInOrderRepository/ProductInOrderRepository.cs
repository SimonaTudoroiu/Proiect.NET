using Project_Tudoroiu_Simona_251.Data;
using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Repositories.GenericRepository;

namespace Project_Tudoroiu_Simona_251.Repositories.ProductInOrderRepository
{
    public class ProductInOrderRepository : GenericRepository<ProductInOrder>, IProductInOrderRepository
    {
        public ProductInOrderRepository(ProjectContext context) : base(context) { }
    }
}
