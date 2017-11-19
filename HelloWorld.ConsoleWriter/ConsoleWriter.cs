using System;
using HelloWorld.Common;

namespace HelloWorld.Screen
{
    public class ConsoleWriter : IWriter
    {
        public string WriteMessage(string message)
        {
            Console.Write(message);
            return message;
        }
    }
}
