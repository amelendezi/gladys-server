using System.Configuration;
using Gladys.Repository.Model.Domain;

namespace Gladys.Repository.Model
{
    public static class DataEntityFactory
    {
        public static IDataEntity GetDataEntity(string type)
        {
            switch (type.ToLowerInvariant())
            {
                case "residence":
                    return new Residence();
                default:
                    return null;
            }
        }
    }
}