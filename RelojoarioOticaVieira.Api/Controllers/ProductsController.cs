using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelojoariaOticaVieira.Api.Repositories;
using RelojoariaOticaVieira.Models.DTOs;

namespace RelojoariaOticaVieira.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetItens()
        {
            try
            {
                var products = await _productRepository.GetItens();
                if (products is null)
                    return NotFound();
                else
                    return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
