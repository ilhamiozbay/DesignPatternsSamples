using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    // UML diyagramındaki Implementor (IMessageSender) arayüzüne denk gelmektedir.
    // Abstraction (Message) tarafından referansı tutulur ve haberleşme burası ile gerçekleşir.
    internal interface IMessageSender
    {
        void SendMessage(Message message);
    }
}
