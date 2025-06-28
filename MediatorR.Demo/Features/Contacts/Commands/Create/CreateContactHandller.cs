using MediatR;

namespace MediatorR.Demo.Features.Contacts.Commands.Create
{
    public class CreateContactHandller: IRequestHandler<CreateContactCommand, int>
    {
        private readonly AppDbContext _db;
        public CreateContactHandller(AppDbContext db)
        {
            _db = db;
        }
        public async Task<int> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = new Contact
            {
                FirstName = request.FirstName,
                LastName = request.LastName
            };
            _db.Contacts.Add(contact);
            await _db.SaveChangesAsync(cancellationToken);
            return contact.Id;
        }
    }
   
}
