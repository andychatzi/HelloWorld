using HelloWorld.Common;

namespace HelloWorld.Database
{
    public class DatabaseWriter : IWriter
    {       
        public string WriteMessage(string message)
        {            
            //write to db
            return message;
        }
    }
}
