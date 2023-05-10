using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MqttProject.Data;
using MqttProject.Models;
using System.ComponentModel;
using static MqttProject.Models.contact;

namespace MqttProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly contactData dbContext /*_contactData*/;
        public BooksController(contactData contactData)
        {
            dbContext = contactData;
        }


        [HttpPost("add")]
        public IActionResult Add([FromBody] Book book)
        {
            dbContext.Books.Add(book);
            dbContext.SaveChanges();

            return Created("",book);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody]int id)
        {
            
            var book = await dbContext.Books.FindAsync(id);
            dbContext.Books.Remove(book);
            
            await dbContext.SaveChangesAsync();
            dbContext.SaveChanges();
            return NoContent();
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody]int id)
        {
            var book = await dbContext.Books.FindAsync(id);
            dbContext.Books.Update(book);
            dbContext.SaveChanges();
            return NoContent();
        }


        [HttpGet("getall")]
        public  IActionResult GetAll()
        {
            var data = dbContext.Books.ToList();
            return Ok(data);
          
        }

        [HttpGet("getbyid")]
        public  IActionResult GetById(int id)
        {
            var data = dbContext.Books.FirstOrDefault(x=>x.id.Equals(id));

            return Ok(data);
          

        }

    }
}
