using MediatorR.Demo.Features.Contacts.Dtos;
using MediatR;

namespace MediatorR.Demo.Features.Contacts.Queries.Get
{
    public class GetContactQueryHandller : IRequestHandler<GetContactQuery, ContactDto>
    {
        private readonly AppDbContext _db;

        public GetContactQueryHandller(AppDbContext db)
        {
            _db = db;
        }

        public async Task<ContactDto> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
           var contact = await _db.Contacts.FindAsync(request.Id)
                ?? throw new KeyNotFoundException($"Contact with ID {request.Id} not found.");

            return new ContactDto(contact.Id, contact.FirstName, contact.LastName);
        }
    }
    
}
