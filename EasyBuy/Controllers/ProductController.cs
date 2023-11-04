using Microsoft.AspNetCore.Mvc;

namespace EasyBuy.Controllers;

public class ProductController : BaseApiController
{
	[HttpGet]
	public ActionResult GetAll()
	{
		return Ok("All Products");
	}
}