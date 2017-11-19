using System;
using HelloWorld.Common;
using HelloWorld.Api.Interfaces;
using HelloWorld.Screen;
using HelloWorld.Database;
using HelloWorld.Mobile;
using HellowWorld.Web;

namespace HelloWorld.Api
{
    public class WriterFactory : IWriterFactory
    {
        IWriter _writer;

        public WriterFactory()
        {
            if (Enum.TryParse(ApplicationSettings.WriterType, out WriterType type))
            {
                var writer = CreateInstance(type) as IWriter;
                _writer = writer;
            }
            else
            {
                throw new Exception("No Settings section was found or could not configure writer.  Check the application settings.");
            }
        }

        IWriter IWriterFactory.GetWriter()
        {
            return _writer;
        }

        private IWriter CreateInstance(WriterType type)
        {
            switch(type)
            {
                case WriterType.Database:
                    return new DatabaseWriter();
                case WriterType.Mobile:
                    return new MobileWriter();
                case WriterType.Web:
                    return new WebWriter();
                default:
                    return new ConsoleWriter();
            }
        }
    }
}
