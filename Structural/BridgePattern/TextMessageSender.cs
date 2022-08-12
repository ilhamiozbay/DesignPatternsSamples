﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    // UML diyagramındaki ConcreteImplementor (TextMessageSender) kısmına denk gelmektedir.
    // Implementor arayüzünü (IMessageSender) uygular.
    internal class TextMessageSender : IMessageSender
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine("TextMessageSender: Sending text message...");
        }
    }
}
