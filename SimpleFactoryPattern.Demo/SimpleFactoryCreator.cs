using SharedLibrary.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Demo
{
    public static class SimpleFactoryCreator
    {
        public static INotification GetCreator(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmailNotification(),
                "sms" => new SmsNotification(),
                "push" => new PushNotification(),
                _ => throw new ArgumentException("Invalid notification type", nameof(type)),
            };
        }
    }
}
