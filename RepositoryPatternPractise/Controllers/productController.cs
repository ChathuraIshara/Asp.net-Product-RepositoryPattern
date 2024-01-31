using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternPractise.Data;
using RepositoryPatternPractise.Models;
using RepositoryPatternPractise.Repositories;

namespace RepositoryPatternPractise.Controllers
{


    [Microsoft.AspNetCore.Mvc.Route("api/productapi")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _prodouctRepository;
        public ProductController(IProductRepository productRepository)
        {
            _prodouctRepository = productRepository;
           

        }


        [HttpGet]
        public ActionResult GetProducts()
        {
            var allproducts= _prodouctRepository.GetProducts().ToList();
            return Ok(allproducts);
        }

        [HttpGet("{id}")]
        public ActionResult GetProduct(int id)
        {
            var product=_prodouctRepository.GetById(id);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            _prodouctRepository.Delete(id);
            _prodouctRepository.Save();
            return NoContent();
        }

        [HttpPost]
        public ActionResult PostProduct([FromBody]Product product) {

            _prodouctRepository.Insert(product);
            _prodouctRepository.Save();
            return Ok();



        }

        [HttpPut]
        public ActionResult UpdateProductPrice(Product product)
        {
            _prodouctRepository.Update(product);
            _prodouctRepository.Save();
            return Ok();
        }
        

    }
}
