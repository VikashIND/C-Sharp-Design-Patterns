## Getting Started
# .NET 8 Design Patterns and CQRS Demo Projects

This repository contains multiple demo projects illustrating common design patterns and architectural approaches in .NET 8, including the Simple Factory Pattern and the CQRS pattern with MediatR.

---

## Projects

### 1. MediatorR.Demo

A simple ASP.NET Core Web API project demonstrating the CQRS (Command Query Responsibility Segregation) pattern using MediatR and Entity Framework Core (In-Memory).

**Key Features:**
- ASP.NET Core 8 Web API
- MediatR for request/response and handler separation
- CQRS pattern for clean separation of queries and commands
- Entity Framework Core with In-Memory database for easy testing
- Swagger/OpenAPI for API documentation
- Example CRUD operations for a `Contact` entity

**Getting Started:**
- Navigate to the `MediatorR.Demo` folder for project-specific instructions and code.

---

### 2. SimpleFactoryPattern.Demo

A console application demonstrating the Simple Factory Pattern for creating different types of notifications (Email, SMS, Push).

**Key Features:**
- .NET 8 Console Application
- Demonstrates the Simple Factory Pattern
- Easily extendable to support new notification types
- Interactive console interface for sending notifications

**How it works:**
- The user is prompted to enter a notification type (`email`, `sms`, or `push`).
- The factory creates the appropriate notification object and sends a message.

**Getting Started:**
- Navigate to the `SimpleFactoryPattern.Demo` folder for project-specific instructions and code.

---

## Repository Structure

<pre>
C Shart Design Patterns
|   ├── MediatorR.Demo
│   ├── Controllers
│   ├── Features
│   │   └── Contacts
│   │       └── Queries
│   │           └── Get
│   ├── CQRS
│   ├── AppDbContext.cs
│   ├── Contact.cs
│   ├── Program.cs
│   └── ...
├── SimpleFactoryPattern.Demo
│   ├── Program.cs
│   ├── INotification.cs
│   ├── EmailNotification.cs
│   ├── SmsNotification.cs
│   ├── PushNotification.cs
│   ├── NotificationFactory.cs
│   └── ...
└── README.md
</pre>


### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or any compatible IDE

### Running the Project

1. **Clone the repository:**
   git clone git@github.com:VikashIND/C-Sharp-Design-Patterns.git cd MediatorR.Demo
   
3. **Restore dependencies:**
   
3. **Run the application:**
   dotnet run --project MediatorR.Demo
   
4. **Open Swagger UI:**
   - Navigate to `https://localhost:5001/swagger` (or the URL shown in the console) to explore and test the API endpoints.

## Project Structure

- `Controllers/` - API controllers (e.g., `ContactsController`)
- `Features/Contacts/` - MediatR request and handler implementations
- `Contact.cs` - The Contact entity model
- `AppDbContext.cs` - Entity Framework Core database context
- `Program.cs` - Application startup and service configuration

## Example API Usage

- **Get Contact by ID**
- GET /api/contact/{id}
- 
## Technologies Used

- ASP.NET Core 8
- MediatR
- Entity Framework Core (In-Memory)
- Swagger (Swashbuckle)

## License

This project is licensed under the MIT License.

  
