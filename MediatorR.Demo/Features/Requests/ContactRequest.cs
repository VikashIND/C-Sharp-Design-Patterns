using MediatR;

namespace MediatorR.Demo.CQRS.Requests
{

    public class ContactRequest : IRequest<Contact>
    {
        public int Id { get; set; }
        public ContactRequest()
        {
            
        }
        public ContactRequest(int id)
        {
            Id = id;
        }
    }
    public class RequestHandler : IRequestHandler<ContactRequest, Contact>
    {
        private readonly AppDbContext _dbContext;
        public RequestHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Contact> Handle(ContactRequest request, CancellationToken cancellationToken)
        {
            return await _dbContext.Contacts.FindAsync(request.Id) ?? throw new KeyNotFoundException($"Contact with ID {request.Id} not found.");
        }
    }
}
