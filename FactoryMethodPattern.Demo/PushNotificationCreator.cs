using SharedLibrary.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Demo
{
    internal class PushNotificationCreator: NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new PushNotification();
        }
    }
    
}
