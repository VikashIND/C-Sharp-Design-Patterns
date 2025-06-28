# MediatorR.Demo

A simple ASP.NET Core Web API demo project using MediatR and Entity Framework Core (In-Memory) to demonstrate the CQRS (Command Query Responsibility Segregation) pattern.

## Features

- ASP.NET Core 8 Web API
- MediatR for CQRS pattern and request/response handling
- Entity Framework Core with In-Memory database for easy testing and demo purposes
- Swagger/OpenAPI support for API documentation
- Example CRUD operations for a `Contact` entity

## Getting Started

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

  
