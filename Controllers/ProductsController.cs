using aon_final_assessment.Models;
using aon_final_assessment.Models.DTOs;
using aon_final_assessment.Services;
using Microsoft.AspNetCore.Mvc;

namespace aon_final_assessment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProducts(long id)
        {
            Product? storedProduct = await _productService.FindByIdAsync(id);
            if (storedProduct == null)
                return NotFound("product not found");

            return Ok(storedProduct);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductInputDTO productInputDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values);
            
            if (productInputDTO.ExpirationDate != null && productInputDTO.ProductionDate >= productInputDTO.ExpirationDate)
                return BadRequest("production date must be earlier than expiration date");

            Product newProduct = Product.FromProductInputDTO(productInputDTO);
            await _productService.SaveAsync(newProduct);
            return CreatedAtAction(nameof(GetProducts), new { id = newProduct.Id }, null);
        }

    }
}
