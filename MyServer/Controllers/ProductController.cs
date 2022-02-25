using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetCustomers()
        {
            var result = _productService.GetProducts();

            return Ok(result);
        }

    }
}
