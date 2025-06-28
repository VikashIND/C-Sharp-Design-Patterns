using MediatorR.Demo.Features.Contacts.Dtos;
using MediatR;

namespace MediatorR.Demo.Features.Contacts.Queries.Get
{
    public record GetContactQuery(int Id) : IRequest<ContactDto>;
}
