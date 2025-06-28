using MediatorR.Demo.Features.Contacts.Dtos;
using MediatR;

namespace MediatorR.Demo.Features.Contacts.Queries.List
{
    public class ListContactQuery : IRequest<List<ContactDto>>;
}
