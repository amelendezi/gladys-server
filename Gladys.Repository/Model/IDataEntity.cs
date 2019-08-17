using System;

namespace Gladys.Repository.Model
{
  public interface IDataEntity
  {
    Guid Id { get; }

    void Load();

    void Save();
  }
}
