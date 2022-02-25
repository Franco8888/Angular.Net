using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MyServer.Models;
using MyServer.Services;

namespace MyServer.Controllers
{
    [ApiController]
    [Route("api/test/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        // ------------------------------------------------------------------------------------------------------------------------------------------------------------ //
        // CTOR
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------ //

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // ------------------------------------------------------------------------------------------------------------------------------------------------------------ //
        // POST getproducts
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------ //

        [HttpPost("getproducts")]
        public IActionResult GetProducts()
        {
            var result = _productService.GetProducts();

            return Ok(result);
        }

        // ------------------------------------------------------------------------------------------------------------------------------------------------------------ //
        // POST addproduct
        // ------------------------------------------------------------------------------------------------------------------------------------------------------------ //

        [HttpPost("addproduct")]
        public IActionResult AddProduct([FromBody] Product body)
        {
            var result = _productService.AddProduct(body);

            return Ok(result);
        }

    }
}
