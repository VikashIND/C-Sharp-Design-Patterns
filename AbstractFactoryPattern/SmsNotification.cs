using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class SmsNotification: ISmsNotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Sending SMS to {to} with message: {message}");
        }
    }
   
}
