namespace BridgePattern
{
    // UML diyagramındaki RefinedAbstraction kısmına denk gelmektedir.
    // Abstraction (Message) sınıfından türer.
    internal class TextMessage : Message
    {
        public TextMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        public override void Send()
        {
            _messageSender.SendMessage(this);
        }
    }
}
