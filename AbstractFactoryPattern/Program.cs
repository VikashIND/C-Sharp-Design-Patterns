// See https://aka.ms/new-console-template for more information
using AbstractFactoryPattern;

Console.WriteLine("Abstract Factory Pattern");

var factory = new NotificationFactory();
factory.CreateEmailNotification()?.Send("john@example.com", "Welcome via Email!");
factory.CreateSmsNotification()?.Send("9999999999", "Your OTP is 123456");
factory.CreatePushNotification().Send("john@example.com", "You've got a new message.");