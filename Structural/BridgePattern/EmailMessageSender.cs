using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    // UML diyagramındaki ConcreteImplementor (EmailMessageSender) kısmına denk gelmektedir.
    // Implementor arayüzünü (IMessageSender) uygular.
    internal class EmailMessageSender : IMessageSender
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine("EmailMessageSender: Sending email message...");
        }
    }
}
