using AutoStrada.DAL;
using AutoStrada.ENT;
using AutoStrada.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoStrada.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly IDataService _db;

        public ProductController(IDataService db)
        {
            _db = db;
        }       

        [HttpGet]
        [Route("CodeProduct/{CodeProduct}")]
        public PaginatedProduct GetByCode(int CodeProduct)
        {
            return _db.Products.GetByCode(CodeProduct);
        }

        [HttpGet]
        public PaginatedProduct Get([FromQuery] QueryParams qp)
        {
            return _db.Products.GetProducts(qp.Page, qp.ProductsPerPage);
        }

        [HttpPost]
        public int Post([FromBody] Product product)
        {
            return _db.Products.Add(product);
        }

        [HttpPut]
        public int Put([FromBody] Product product)
        {
            return _db.Products.Update(product);
        }

        [HttpDelete]
        public int Delete([FromBody] Product product)
        {
            return _db.Products.Remove(product);
        }
    }
}
