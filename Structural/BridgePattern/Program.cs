// Bridge tasarım deseni, soyutlanmış (abstract) yapıyı implementasyonundan (uygulamasından) ayırmaya, bağımsız olarak geliştirilebilir iki yapı elde etmemize yarar.
// miras yoluyla soyutlamalar her zaman esnek değildir. Kalıtım kullandığımızda, uygulamayı kalıcı olarak soyutlamaya bağlarız. Sonuç olarak, birinde yapılan herhangi bir değişiklik diğerini etkiler. Buradaki daha esnek bir yol, soyutlamayı ve uygulamayı ayırmaktır ve bridge tasarım deseni bu noktada devreye girer.

using BridgePattern;

IMessageSender textSender = new TextMessageSender();
IMessageSender emailSender = new EmailMessageSender();

Message textMessage=new TextMessage(textSender);
Message emailMessage=new EmailMessage(emailSender); //parametrede textSender gönderilebiliyor

textMessage.Send();
emailMessage.Send();
