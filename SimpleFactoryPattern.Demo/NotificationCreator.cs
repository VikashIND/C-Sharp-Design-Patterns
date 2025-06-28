using SharedLibrary.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Demo
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();
        public void Notify(string to, string message)
        {
            var notification = CreateNotification();
            notification.Send(to, message);
        }
    }
}
