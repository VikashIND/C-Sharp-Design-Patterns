using MediatorR.Demo.Features.Contacts.Dtos;
using MediatR;

namespace MediatorR.Demo.Features.Contacts.Commands.Update
{
    public class UpdateContactHandller(AppDbContext _db) : IRequestHandler<UpdateContactCommand, ContactDto>
    {
        public async Task<ContactDto> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = _db.Contacts.FirstOrDefault(c => c.Id == request.Id);
            if (contact == null) return null;
            contact.FirstName = request.FirstName;
            contact.LastName = request.LastName;
            _db.Contacts.Update(contact);
            await _db.SaveChangesAsync(cancellationToken);

            return new ContactDto(contact.Id, contact.FirstName, contact.LastName);

        }
    }
}
