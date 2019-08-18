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

    public Guid Id { get; }

    public string Alias { get; }

    public string ResidenceOwnerName { get; }

    public string ResidentName { get; }

    public void Load()
    {
      throw new NotImplementedException();
    }

    public void Save()
    {
      throw new NotImplementedException();
    }
  }
}
