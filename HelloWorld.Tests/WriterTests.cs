using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using HelloWorld.Api;
using HelloWorld.Api.Interfaces;
using HelloWorld.Screen;

namespace HelloWorld.Tests
{
    [TestClass]
    public class WriterTests
    {
        private const string HelloWorld = "Hello World";
        private Mock<IWriterFactory> _mockConfig;

        [TestInitialize]
        public void Initialize()
        {
            _mockConfig = new Mock<IWriterFactory>();
        }

        [TestMethod]
        public void TestConsoleWriterSuccess()
        {
            _mockConfig.Setup(x => x.GetWriter()).Returns(new ConsoleWriter());
            WriteManager mgr = new WriteManager(_mockConfig.Object);            
            var msg = mgr.write(HelloWorld);          
            Assert.AreEqual(msg, HelloWorld);
        }

        [TestMethod]
        public void TestDatabaseWriterSuccess()
        {
            _mockConfig.Setup(x => x.GetWriter()).Returns(new Database.DatabaseWriter());
            WriteManager mgr = new WriteManager(_mockConfig.Object);           
            var msg = mgr.write(HelloWorld);            
            Assert.AreEqual(msg, HelloWorld);
        }

        [TestMethod]
        public void TestMobileWriterSuccess()
        {
            _mockConfig.Setup(x => x.GetWriter()).Returns(new Mobile.MobileWriter());
            WriteManager mgr = new WriteManager(_mockConfig.Object);
            var msg = mgr.write(HelloWorld);
            Assert.AreEqual(msg, HelloWorld);
        }

        [TestMethod]
        public void TestWebWriterSuccess()
        {
            _mockConfig.Setup(x => x.GetWriter()).Returns(new HellowWorld.Web.WebWriter());
            WriteManager mgr = new WriteManager(_mockConfig.Object);
            var msg = mgr.write(HelloWorld);
            Assert.AreEqual(msg, HelloWorld);
        }
    }
}
