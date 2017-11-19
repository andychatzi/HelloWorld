using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Common;

namespace HelloWorld.Api.Interfaces
{
    public interface IWriterFactory 
    {
        IWriter GetWriter();
    }
}
