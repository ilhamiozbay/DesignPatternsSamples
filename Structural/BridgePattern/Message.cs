using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    // UML diyagramındaki Abstraction kısmına denk gelmektedir.
    // Implementor (IMessageSender) arayüzünün referansını tutmaktadır.
    internal abstract class Message
    {
        protected IMessageSender _messageSender;

        protected Message(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public abstract void Send();
    }
}
