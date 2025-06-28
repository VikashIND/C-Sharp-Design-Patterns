using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Demo
{
    public static class NotificationCreatorFactory
    {
        public static NotificationCreator GetCreator(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmailNotificationCreator(),
                "sms" => new SmsNotificationCreator(),
                "push" => new PushNotificationCreator(),
                _ => throw new ArgumentException("Invalid notification type", nameof(type)),
            };
        }
    }
}
