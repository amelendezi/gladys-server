namespace Gladys.Api.Model
{
  public class ResidenceModel
  {
    public ResidenceModel(Guid id, string alias, string residenceOwnerName, string residentName)
    {
      Id = id;
      Alias = alias;
      ResidenceOwnerName = residenceOwnerName;
      ResidentName = residentName;
    }

    public Guid Id { get; }
    
    public string Alias { get; }

    public string ResidenceOwnerName { get; }

    public string ResidentName { get; }
  }
}
