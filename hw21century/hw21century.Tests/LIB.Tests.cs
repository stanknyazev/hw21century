using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using hw21century.LIB;
using hw21century.LIB.DB;
using hw21century.LIB.Console;

using Moq;

namespace hw21century.Tests
{
    [TestClass]
    public class LIBTests
    {
        DataMessage testmessage;

        [TestInitialize]
        public void TestSetup()
        {
            testmessage = new DataMessage() { Text = "Hello World, it is 21st century today." };
        }
        [TestMethod]
        public void ConsoleMessageHandlerTest()
        {
            var iWriter = new Mock<ITextWriter>();
            var iSender = new Mock<ConsoleMessageHandler>(iWriter.Object);
            iSender.CallBase = true;
            var Sender = iSender.Object;

            Sender.SendMessage(testmessage);

            iSender.Verify(s => s.SendMessage(testmessage), Times.Exactly(1));
            iWriter.Verify(w => w.WriteText(It.Is<string>(s => s == testmessage.Text)), Times.Once);
        }
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void DBMessageHandlerTest()
        {
            IMessageHandler _messageHandler = new DBMessageHandler();
            _messageHandler.SendMessage(testmessage);
        }
    }
}
