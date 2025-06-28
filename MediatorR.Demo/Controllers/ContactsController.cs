using MediatorR.Demo.CQRS.Requests;
using MediatorR.Demo.Features.Contacts.Commands.Create;
using MediatorR.Demo.Features.Contacts.Commands.Delete;
using MediatorR.Demo.Features.Contacts.Commands.Update;
using MediatorR.Demo.Features.Contacts.Queries.List;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatorR.Demo.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly IMediator _mediator;
        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllContacts()
        {
            var contacts = await _mediator.Send(new ListContactQuery());
            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public async Task<Contact> GetContact([FromRoute] int id)
        {
            var contact = await _mediator.Send(new ContactRequest(id));
            return contact;
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact([FromBody] CreateContactCommand command)
        {
            if (command == null)
            {
                return BadRequest("Invalid contact data.");
            }
            var contactId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetContact), new { id = contactId }, null);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContact([FromBody] UpdateContactCommand command)
        {
            if (command == null)
            {
                return BadRequest("Invalid contact data.");
            }
            var updatedContact = await _mediator.Send(command);
            if (updatedContact == null)
            {
                return NotFound($"Contact with ID {command.Id} not found.");
            }
            return Ok(updatedContact);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact([FromRoute] int id)
        {
            var command = new DeleteContactCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
