using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using myRetailApi.Models;

namespace myRetailApi.Controllers
{
	[Route("api/Products")]
	public class ProductsController : Controller
	{
		// GET api/values
		[HttpGet("{id}")]
		public JsonResult GetProduct(double id)
		{

			return Json(products.Where(x => x.Id == id).FirstOrDefault());
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] Product product)
		{
		}


		private List<Product> products = new List<Product>
		{
			new Product{
				Id=15117729,

			},
			new Product{
				Id=16483589,
			},
			new Product{
				Id=16696652,
			},
			new Product{
				Id=16752456,
			},
			new Product{
				Id=15643793,
			}
		};
	}
}