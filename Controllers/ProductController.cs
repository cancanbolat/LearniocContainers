using iocContainers.Repository;
using Microsoft.AspNetCore.Mvc;

namespace iocContainers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly INameService nameService;
        private readonly IProduct product;
        public ProductController(IProduct product, INameService nameService)
        {
            this.product = product;
            this.nameService = nameService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(product.GetAllProduct());
        }

    }
}