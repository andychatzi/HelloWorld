using System;
using HelloWorld.Api;
using HelloWorld.Api.Interfaces;

namespace HelloWorld.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new WriterFactory();

            IWriteManager helloWorldWriter = new WriteManager(factory);

            helloWorldWriter.write("Hello World");

            Console.ReadLine();
        }
    }
}
