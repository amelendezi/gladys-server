using Microsoft.AspNetCore.Mvc;

namespace GladysServer.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class QueryController : ControllerBase
  {
    // GET api/query
    [HttpGet("{name}")]
    public ActionResult<string> Get(string name)
    {
      // Todo: Json
      return "";
    }
  }
}
