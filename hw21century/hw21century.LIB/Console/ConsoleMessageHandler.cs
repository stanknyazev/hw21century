using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw21century.LIB.Console
{
    public class ConsoleMessageHandler : IMessageHandler
    {
        ITextWriter _writer;
        public ConsoleMessageHandler()
        {
            _writer = new ConsoleTextWriter();
        }
        public ConsoleMessageHandler(ITextWriter textWriter)
        {
            _writer = textWriter;
        }
        public override void SendMessage(DataMessage message) {
            _writer.WriteText(message.Text);
        }
    }
}

