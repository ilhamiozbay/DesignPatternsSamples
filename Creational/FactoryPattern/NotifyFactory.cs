namespace FactoryPattern
{
    interface INotify
    {
        void SendNotification(User user);
    }

    class MailNotify : INotify
    {
        public void SendNotification(User user)
        {
            Console.WriteLine($"Email sent to {user.Mail}, user with Id: {user.Id}");
        }
    }

    class SmsNotify : INotify
    {
        public void SendNotification(User user)
        {
            Console.WriteLine($"Sms sent to {user.Phone}, user with Id: {user.Id}");
        }
    }

    enum NotifyType : byte
    {
        SMS,
        MAIL
    }

    class NotifyFactory
    {
        public INotify CreateNotify(NotifyType notifyType)
        {
            if (notifyType == NotifyType.SMS)
            {
                return new SmsNotify();
            }
            else if (notifyType == NotifyType.MAIL)
            {
                return new MailNotify();
            }
            return null;
        }
    }
}
