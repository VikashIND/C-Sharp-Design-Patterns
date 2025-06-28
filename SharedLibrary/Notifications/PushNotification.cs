using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Notifications
{
    public class PushNotification: INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Sending Push Notification to {to}: {message}");
        }
    }
}
