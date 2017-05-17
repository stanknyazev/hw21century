using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hw21century.LIB;
using hw21century.LIB.Console;


namespace hw21century.ConsoleApp
{
    class Program
    {
        static IMessageHandler _messageHandler=new ConsoleMessageHandler();
        static void Main(string[] args)
        {
            _messageHandler.SendMessage(new DataMessage() { Text = args[0] });
            Console.ReadLine();
        }
    }
}
