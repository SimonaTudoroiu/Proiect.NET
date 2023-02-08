using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Tudoroiu_Simona_251.Models.DTOs.Product;
using Project_Tudoroiu_Simona_251.Models.Enums;
using Project_Tudoroiu_Simona_251.Services.ProductService;
using System.Runtime.CompilerServices;

namespace Project_Tudoroiu_Simona_251.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await _productService.GetAll());
        }
        
        [HttpGet("grouped")]
        public async Task<IActionResult> GetAllProductsGrouped()
        {
            return Ok(_productService.GetAllGroupedByTypes());
        }
        [HttpGet("byTypes")]
        public async Task<IActionResult> GetAllProductsByTypes([FromQuery] List<ProductType> types)
        {
            return Ok(await _productService.GetAllByTypes(types));
        }
        [HttpGet("byBeautyTypes")]
        public async Task<IActionResult> GetAllProductsByBeautyTypes([FromQuery] List<ProductTypeBeauty?> types)
        {
            return Ok(await _productService.GetAllByBeautyTypes(types));
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductDTO newProduct)
        {
            await this._productService.AddProduct(newProduct);
            return Ok();
        }
        [HttpPut("{name}")]
        public async Task<IActionResult> UpdateProduct([FromRoute] string name, [FromBody] ProductDTO newProduct)
        {
            await this._productService.UpdateByName(name, newProduct);
            return Ok();
        }
        [HttpDelete("{productName}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] string productName)
        {
            await this._productService.DeleteProductByName(productName);
            return Ok();
        }
    }
}
