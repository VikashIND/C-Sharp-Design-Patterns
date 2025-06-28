using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class EmailNotification : IEmailNotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Sending Email to {to} with message: {message}");
        }
    }
}
