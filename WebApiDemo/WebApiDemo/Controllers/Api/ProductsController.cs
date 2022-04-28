using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using WebApiDemo.Models;
using System.Web.Http;


namespace WebApiDemo.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]{
         new Product { ID = 1, Name = "Chocolate", AddingDate =
            DateTime.Parse(DateTime.Today.ToString()), Numbers = 30 },
         new Product { ID = 2, Name = "Biscuits", AddingDate =
            DateTime.Parse(DateTime.Today.ToString()), Numbers = 20 },
         new Product { ID = 3, Name = "Biscuits", AddingDate =
            DateTime.Parse(DateTime.Today.ToString()), Numbers = 20 },
        };
        public IEnumerable<Product> GetAllProduct()
        {
            return products;
        }
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.ID == id);
            
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
