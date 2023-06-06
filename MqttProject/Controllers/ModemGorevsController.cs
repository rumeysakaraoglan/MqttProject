using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MqttProject.Data;

namespace MqttProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModemGorevsController : ControllerBase
    {

        private readonly contactData _dbContext;
        public ModemGorevsController(contactData dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _dbContext.ModemGorevs.Include(message => message.Komut).ToListAsync();
            return Ok(data);
        }
    }
}
