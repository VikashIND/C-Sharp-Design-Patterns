using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Interfaces
{
    internal interface INotificationFactory
    {
        IEmailNotification CreateEmailNotification();
        ISmsNotification CreateSmsNotification();
        IPushNotification CreatePushNotification();
    }
}
