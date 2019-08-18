using Gladys.Repository.MySql;
using NUnit.Framework;

namespace Gladys.Repository.Tests.MySql
{
    [TestFixture]
    public class MySqlConnectionStringParserTests
    {
        [Test]
        public void On_Load_ReturnsCorrectConfig()
        {
            var result = MySqlConnectionStringParser.Load(MySqlTestConstants.ConnectionConfigPath);
            
            Assert.AreEqual(expected: "gladys", actual: result.User);
            Assert.AreEqual(expected: "gladyspass", actual: result.Password);
            Assert.AreEqual(expected: "localhost", actual: result.Server);
            Assert.AreEqual(expected: "gladysdb", actual: result.Database);
        }
        
        [Test]
        public void On_Parse_ReturnsCorrectConfig()
        {
            string sample = "Uid=gladys;Pwd=gladyspass;Server=localhost;Database=gladysdb";

            var result = MySqlConnectionStringParser.Parse(sample);
            
            Assert.AreEqual(expected: "gladys", actual: result.User);
            Assert.AreEqual(expected: "gladyspass", actual: result.Password);
            Assert.AreEqual(expected: "localhost", actual: result.Server);
            Assert.AreEqual(expected: "gladysdb", actual: result.Database);
        }

        [Test]
        public void On_SerializeToConnectionString_ReturnsCorrectString()
        {
            var sample = new MySqlConnectionConfig()
            {
                User = "gladys",
                Password = "gladyspass",
                Server = "localhost",
                Database = "gladysdb"
            };
            
            string result = MySqlConnectionStringParser.SerializeToConnectionString(sample);
            
            Assert.AreEqual(expected: "Uid=gladys;Pwd=gladyspass;Server=localhost;Database=gladysdb", actual: result);
        }
    }
}