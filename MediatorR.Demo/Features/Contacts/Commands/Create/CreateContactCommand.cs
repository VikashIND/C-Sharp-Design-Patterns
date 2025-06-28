using MediatR;

namespace MediatorR.Demo.Features.Contacts.Commands.Create
{
    public record CreateContactCommand(int Id, string FirstName, string LastName): IRequest<int>;
    
}
