using FactoryMethodPattern.Demo;

do
{
    Console.Clear();
    Console.WriteLine("Factory Method Pattern");
    
    Console.WriteLine("Enter notification type (email/sms/push):");
    string type = Console.ReadLine();

    NotificationCreator notification = NotificationCreatorFactory.GetCreator(type);
    notification.Notify("john@example.com", "Hello from the notification system!");

    const string instructions = "Press 'Escape' to exit, or any other key to continue.";
    Console.WriteLine(instructions);
} while (Console.ReadKey(true).Key != ConsoleKey.Escape);
