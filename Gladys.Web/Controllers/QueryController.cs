using Microsoft.AspNetCore.Mvc;

namespace Gladys.Web.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class QueryController : ControllerBase
  {
    // GET api/values
    [HttpGet("{queryName}")]

    public ActionResult<string> Get(string queryName)
    {
      return "Some default json";
    }
  }
}
