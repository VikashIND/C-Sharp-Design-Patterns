using SharedLibrary.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Demo
{
    internal class SmsNotificationCreator: PushNotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }
   
}
