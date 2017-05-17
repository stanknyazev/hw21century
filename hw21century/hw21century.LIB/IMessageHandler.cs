using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw21century.LIB
{
    public abstract class IMessageHandler
    {
        public abstract void SendMessage(DataMessage message);
    }
}
