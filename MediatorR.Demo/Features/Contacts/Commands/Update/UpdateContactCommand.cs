using MediatorR.Demo.Features.Contacts.Dtos;
using MediatR;

namespace MediatorR.Demo.Features.Contacts.Commands.Update
{
    public record UpdateContactCommand(int Id, string FirstName, string LastName) : IRequest<ContactDto>;
}
