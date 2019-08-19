using System;

namespace Gladys.Repository.Model
{
  public interface IDataEntity
  {
    string Type { get; }
    
    Guid Id { get; }
  }
}
