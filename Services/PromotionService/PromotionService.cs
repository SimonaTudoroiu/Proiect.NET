using AutoMapper;
using Project_Tudoroiu_Simona_251.Models.DTOs.Product;
using Project_Tudoroiu_Simona_251.Models.DTOs.Promotion;
using Project_Tudoroiu_Simona_251.Repositories.ProductRepository;
using Project_Tudoroiu_Simona_251.Repositories.PromotionRepository;

namespace Project_Tudoroiu_Simona_251.Services.PromotionService
{
    public class PromotionService : IPromotionService
    {
        public IPromotionRepository _promotionRepository;
        public IProductRepository _productRepository;

        public IMapper _mapper;

        public PromotionService(IPromotionRepository promotionRepository, IMapper mapper)
        {
            _promotionRepository = promotionRepository;
            _mapper = mapper;
        }

        public async Task<List<PromotionDTO>> GetAll()
        {
            var promotions = await _promotionRepository.GetAll();
            return _mapper.Map<List<PromotionDTO>>(promotions);
        }
        public DateTime FindFirstDayOfPromotionByProductName(string productName)
        {
            var product = _productRepository.FindByName(productName);
            var productId = product.Id;
            var firstDayOfPromotion = _promotionRepository.FindFirstDayOfPromotionByProductId(productId);
            return firstDayOfPromotion;
        }
        public DateTime FindLastDayOfPromotionByProductName(string productName)
        {
            var product = _productRepository.FindByName(productName);
            var productId = product.Id;
            var lastDayOfPromotion = _promotionRepository.FindLastDayOfPromotionByProductId(productId);
            return lastDayOfPromotion;
        }
    }
}
