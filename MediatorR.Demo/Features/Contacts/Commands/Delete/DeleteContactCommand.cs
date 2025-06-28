using MediatR;

namespace MediatorR.Demo.Features.Contacts.Commands.Delete
{
    public record DeleteContactCommand(int Id): IRequest;
   
}
