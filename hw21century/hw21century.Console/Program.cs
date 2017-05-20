using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hw21century.LIB;
using hw21century.LIB.Console;

using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace hw21century.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer unity = new UnityContainer().LoadConfiguration();
            var program = unity.Resolve<UnityEnabledProgram>();
            program.Run(args);
        }
    }
    public class UnityEnabledProgram
    {
        readonly IMessageHandler _messageHandler;

        public UnityEnabledProgram(IMessageHandler messageHandler)
        {
            _messageHandler = messageHandler;
        }

        public void Run(string[] args)
        {
            _messageHandler.SendMessage(new DataMessage() { Text = args[0] });
        }
    }
}
