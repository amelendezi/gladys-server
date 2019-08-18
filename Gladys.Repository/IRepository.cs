using System;
using Gladys.Repository.Model;
using System.Collections.Generic;

namespace Gladys.Repository
{
  public interface IRepository
  {
    IEnumerable<IDataEntity> GetAll(string type);

    IEnumerable<IDataEntity> GetById(Guid id);
  }
}
