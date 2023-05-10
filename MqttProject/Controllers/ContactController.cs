using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MqttProject.Data;
using MqttProject.Models;
using static MqttProject.Models.contact;

namespace MqttProject.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ContactController : ControllerBase
    {
        private readonly contactData dbContext;
        public ContactController(contactData dbContextarg)
        {
            dbContext = dbContextarg;
        }
       

        [Route("getcontacts", Name = nameof(GetContacts))]
        [HttpGet]
        public async Task<IActionResult>GetContacts()
        {
           return  Ok(await dbContext.Contacts.ToListAsync());
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetContact([FromRoute] Guid id)
        {
            var contact = await dbContext.Contacts.FindAsync(id);
            if(contact == null) { 
              return NotFound();
            }
            return Ok(contact );
        }
        
        [HttpPost]
        public async Task<IActionResult> AddContact(AddContactRequest addContactRequest )
        {
            var contacts = new contact()
            {
                Id = 0,
                ServerAden = addContactRequest.ServerAden,
                SubscribeTopic = addContactRequest.SubscribeTopic
            };
           await dbContext.Contacts.AddAsync(contacts);
            await dbContext.SaveChangesAsync();
            return Ok(contacts);

        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateContact([FromRoute] Guid id, UpdateContactRequest updateContactRequest)
        {

            var contact = await dbContext.Contacts.FindAsync(id); 
            if(contact != null)
            {
                contact.SubscribeTopic= updateContactRequest.SubscribeTopic;
                contact.ServerAden= updateContactRequest.ServerAden;
                await dbContext.SaveChangesAsync();
                return Ok(contact);
            }
            return NotFound();
        }

        [HttpDelete]
        [Route ("{id:guid}")]
        public async Task<IActionResult> DeleteContact([FromRoute] Guid id )
        {
            var contact = await dbContext.Contacts.FindAsync(id);
            if(contact != null)
            {
                dbContext.Remove(contact);
               await dbContext.SaveChangesAsync();
                return Ok(contact);

            }
            return NotFound();

        }
        
    }
}
