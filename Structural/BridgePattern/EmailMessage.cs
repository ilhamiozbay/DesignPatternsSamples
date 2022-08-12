namespace BridgePattern
{
    // UML diyagramındaki RefinedAbstraction kısmına denk gelmektedir.
    // Abstraction (Message) sınıfından türer.
    internal class EmailMessage : Message
    {
        public EmailMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        public override void Send()
        {
            _messageSender.SendMessage(this);
        }
    }
}
