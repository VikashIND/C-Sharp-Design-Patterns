using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class NotificationFactory : INotificationFactory
    {
        public IEmailNotification CreateEmailNotification() => new EmailNotification();      
        public IPushNotification CreatePushNotification() => new PushNotification();
        public ISmsNotification CreateSmsNotification() => new SmsNotification();

    }
}
