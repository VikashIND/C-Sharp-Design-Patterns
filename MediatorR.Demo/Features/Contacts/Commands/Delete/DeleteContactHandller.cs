using MediatR;

namespace MediatorR.Demo.Features.Contacts.Commands.Delete
{
    public class DeleteContactHandller(AppDbContext db) : IRequestHandler<DeleteContactCommand>
    {

        public async Task Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            var contact = db.Contacts.FirstOrDefault(c => c.Id == request.Id);
            
            if (contact == null) return;

            db.Remove(contact);
            await db.SaveChangesAsync();

        }
    }
}
