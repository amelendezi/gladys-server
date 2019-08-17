namespace Gladys.Api.Handlers
{
  public static class RequestHandler
  {
    public static string GetById(string type, string id)
    {
      return $"This is the GetById for the type '{type}' with {id}";
    }

    public static string GetAll(string type, int skip, int take)
    {
      switch (type.ToLowerInvariant())
      {
        case "residence":
          break;
        default:
          break;
      }


      return $"This is the GetAll for type '{type}' with skip {skip} and take {take}";
    }
  }
}
