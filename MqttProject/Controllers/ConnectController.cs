using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MqttProject.Data;
using MqttProject.Models;

namespace MqttProject.Controllers
{
    [Route("api")]
    [ApiController]
  
   
    public class ConnectController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly contactData dbContext;
        public ConnectController(contactData contactData)
        {
            dbContext = contactData;
        }
        [HttpPost("add")]
        public IActionResult Add([FromBody] Connect connect)
        {
             dbContext.Connects.Add(connect);
           // dbContext.SaveChanges();
            return Ok("deneme");
           // return Created("", connect); 
                /* Created("", connect);*/
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {

            var connect = await dbContext.Connects.FindAsync(id);
            dbContext.Remove(connect);

            await dbContext.SaveChangesAsync();
            dbContext.SaveChanges();
            return NoContent();
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] int id)
        {
            var connect = await dbContext.Connects.FindAsync(id);
            dbContext.Update(connect);
            dbContext.SaveChanges();
            return NoContent();
        }

    }
    }

