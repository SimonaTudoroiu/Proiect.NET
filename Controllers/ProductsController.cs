using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Tudoroiu_Simona_251.Data;
using Project_Tudoroiu_Simona_251.Models;
using Project_Tudoroiu_Simona_251.Models.DTOs;

namespace Project_Tudoroiu_Simona_251.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ProjectContext _projectContext;

        public ProductsController(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _projectContext.Products.ToListAsync());
        } 
        [HttpGet("productById/{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] Guid id)
        {
            var productById = from product in _projectContext.Products
                              where product.Id == id
                              select product;

            return Ok(_projectContext.Products.FirstOrDefault(product => product.Id == id));
           
        }

        [HttpPost("CreateProduct")]
        public async Task<IActionResult> Create(ProductDTO productDTO)
        {
            var newProduct = new Product();
            await _projectContext.AddAsync(newProduct);
            await _projectContext.SaveChangesAsync();
            return Ok(newProduct);

        }
    }
}
