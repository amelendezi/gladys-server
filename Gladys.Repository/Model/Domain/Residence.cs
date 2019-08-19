using System;

namespace Gladys.Repository.Model.Domain
{
  public class Residence : IDataEntity
  {
    public Residence()
    {
    }

    public Residence(Guid id, string @alias, string residenceOwnerName, string residentName)
    {
      Id = id;
      Alias = alias;
      ResidenceOwnerName = residenceOwnerName;
      ResidentName = residentName;
    }

    public string Type => "Residence";
    
    public Guid Id { get; set; }

    public string Alias { get; set; }

    public string ResidenceOwnerName { get; set; }

    public string ResidentName { get; set; }
  }
}
