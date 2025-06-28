using SharedLibrary.Notifications;
using SimpleFactoryPattern.Demo;

do
{
    Console.Clear();
    Console.WriteLine("Simple Factory Pattern");
    
    Console.WriteLine("Enter notification type (email/sms/push):");
    string type = Console.ReadLine();

    INotification notification = SimpleFactoryCreator.GetCreator(type);
    notification.Send("john@example.com", "Hello from the notification system!");

    const string instructions = "Press 'Escape' to exit, or any other key to continue.";
    Console.WriteLine(instructions);
} while (Console.ReadKey(true).Key != ConsoleKey.Escape);
