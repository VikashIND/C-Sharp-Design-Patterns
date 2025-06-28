using MediatorR.Demo.Features.Contacts.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatorR.Demo.Features.Contacts.Queries.List
{
    public class ListContactQueryHandller:IRequestHandler<ListContactQuery, List<ContactDto>>
    {
        private readonly AppDbContext _db;
        public ListContactQueryHandller(AppDbContext db)
        {
            _db = db;
        }
        public async Task<List<ContactDto>> Handle(ListContactQuery request, CancellationToken cancellationToken)
        {
            return await _db.Contacts
                .Select(c => new ContactDto(c.Id, c.FirstName, c.LastName))
                .ToListAsync(cancellationToken);
        }
    }
    
}
