using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw21century.LIB.Console
{
    public class ConsoleTextWriter : ITextWriter
    {
        public void WriteText(string text)
        {
            System.Console.WriteLine(text);
        }
    }
}
