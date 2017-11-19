using HelloWorld.Common;

namespace HellowWorld.Web
{
    public class WebWriter : IWriter
    {
        public string WriteMessage(string message)
        {
            //write to web
            return message;
        }
    }
}
