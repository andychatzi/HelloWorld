using HelloWorld.Common;

namespace HelloWorld.Mobile
{
    public class MobileWriter : IWriter
    {
        public string WriteMessage(string message)
        {
           //write to mobile screen
            return message;
        }
    }
}
