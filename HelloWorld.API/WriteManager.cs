using HelloWorld.Common;
using HelloWorld.Api.Interfaces;

namespace HelloWorld.Api
{
    public class WriteManager : IWriteManager
    {
        private readonly IWriter _writer;        

        public WriteManager(IWriterFactory factory)
        {
            _writer = factory.GetWriter(); 
        }

        public string write(string message)
        {
           return _writer.WriteMessage(message);
        }
    }
}
