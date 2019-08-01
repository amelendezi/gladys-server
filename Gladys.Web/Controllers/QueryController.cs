using Gladys.Api.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace Gladys.Web.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class QueryController : ControllerBase
  {
    [HttpGet("{type}/byId")]
    public ActionResult<string> Get(string type, string id)
    {
      return RequestHandler.GetById(type, id);
    }

    [HttpGet("{type}/all")]
    public ActionResult<string> Get(string type, int skip, int take)
    {
      return RequestHandler.GetAll(type, skip, take);
    }
  }
}
