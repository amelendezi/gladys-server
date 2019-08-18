using System.Text;

namespace Gladys.Repository.Log
{
    public class StringBuilderLogger : ILogger
    {
        private readonly StringBuilder _buffer;

        public StringBuilderLogger()
        {
            _buffer = new StringBuilder();
        }

        public void Clear()
        {
            _buffer.Clear();
        }

        public string Dump()
        {
            return _buffer.ToString();
        }

        public ILogger Log(string message)
        {
            _buffer.AppendLine(message);
            return this;
        }
    }
}