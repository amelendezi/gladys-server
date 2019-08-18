namespace Gladys.Repository.Log
{
    public interface ILogger
    {
        ILogger Log(string message);

        string Dump();

        void Clear();
    }
}