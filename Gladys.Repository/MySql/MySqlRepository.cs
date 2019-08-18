using System;
using System.Collections.Generic;
using Gladys.Repository.Model;

namespace Gladys.Repository.MySql
{
  public class MySqlRepository : IRepository
  {
    private MySqlConnectionManager _manager;
    private MySqlConnectionConfig _config;
    
    public MySqlRepository()
    {
      _manager = new MySqlConnectionManager();
      
    }

    public IEnumerable<IDataEntity> GetAll(string type)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<IDataEntity> GetById(Guid id)
    {
      throw new NotImplementedException();
    }
  }
}
