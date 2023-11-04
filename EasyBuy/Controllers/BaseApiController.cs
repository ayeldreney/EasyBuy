using Microsoft.AspNetCore.Mvc;
namespace EasyBuy.Controllers;

[ApiController]
[Route("[controller]")]
public abstract class BaseApiController : ControllerBase
{
}