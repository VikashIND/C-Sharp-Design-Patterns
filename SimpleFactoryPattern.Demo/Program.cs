using SharedLibrary.Notifications;
using SimpleFactoryPattern.Demo;

do
{
    Console.Clear();
    Console.WriteLine("Welcome to the Notification System!");
    
    Console.WriteLine("Enter notification type (email/sms/push):");
    string type = Console.ReadLine();

    NotificationCreator notification = NotificationCreatorFactory.GetCreator(type);
    notification.Notify("john@example.com", "Hello from the notification system!");

    const string instructions = "Press 'Escape' to exit, or any other key to continue.";
    Console.WriteLine(instructions);
} while (Console.ReadKey(true).Key != ConsoleKey.Escape);
