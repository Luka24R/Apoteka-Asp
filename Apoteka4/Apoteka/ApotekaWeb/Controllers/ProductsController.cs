using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApotekaWeb.Models;

namespace ApotekaWeb.Controllers
{
    public class ProductsController : ApiController
    {
        TestProduct[] products = new TestProduct[] 
        { 
            new TestProduct { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new TestProduct { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new TestProduct { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };

        public IEnumerable<TestProduct> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
