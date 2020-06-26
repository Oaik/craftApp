using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using craft.Models;
using craft.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace craft.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService ProductService)
        {
            this.ProductService = ProductService;
        }
        public JsonFileProductService ProductService { get; }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get([FromQuery]string ProductId, [FromQuery] int Rating)
        {
            ProductService.addRating(ProductId, Rating);
            return Ok();
        }
    }
}
