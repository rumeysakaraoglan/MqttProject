using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MqttProject.Data;
using MqttProject.Models;

namespace MqttProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KomutController : ControllerBase
    {
        private readonly contactData dbContext;
            
      public KomutController(contactData contactData) {
            dbContext = contactData;
        }
      

        [HttpPost("add")]
        public async  Task<IActionResult >Add([FromBody]Komut komut)
        {
            await dbContext.Komuts.AddAsync(komut);
            await  dbContext.SaveChangesAsync();
            return Created("",komut);
            
        }
        [HttpDelete("delete ")]
        public async Task<IActionResult> Delete(int Id)
        {
            var komut =await dbContext.Komuts.FindAsync(Id);
            dbContext.Komuts.Remove(komut);
            dbContext.SaveChanges();
             return Ok();
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update(int Id) {
            var komut = await dbContext.Komuts.FindAsync(Id);
            dbContext.Komuts.Update(komut);
            dbContext.SaveChanges();
            return Ok();
        }

        [HttpGet("getallbykomut")]
        public async Task<IActionResult> GetAllKomutByKomutKod([FromQuery]int komutKod)
        {
        
            var komutLists = await dbContext.Komuts.Where(x=>x.KomutKod==komutKod).ToListAsync();
            return Ok(komutLists);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAllAsync()
        {
            var data= await dbContext.Komuts.ToListAsync();
            return Ok(data);
        }

        [HttpGet("getallbymodemid")]  
        public async Task<IActionResult> GetAllKomutsByModemGorev(int KomutId)
        {
            var komutList= await dbContext.Komuts.Where(x=>x.Id==KomutId).ToListAsync();
            return Ok(komutList);
        }

    }
}
