using FBLogIn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FBLogIn.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LogInController : ControllerBase
  { 
    private readonly AplicationDbContext _context;
    public LogInController(AplicationDbContext context)
    {
      _context = context;
    }

    // GET: api/<LogInController>
    [HttpGet]
    public async Task<ActionResult> Get()
    {
      try
      {
        var listarInfomacion =await _context.Informacion.ToListAsync();
        return Ok(listarInfomacion);
      }
      catch(Exception ex)
      {
        return BadRequest(ex.Message);     }
    }





        // GET api/<LogInController>/5
        [HttpGet("{id}")]
        //[Microsoft.AspNetCore.Authorization.Authorize]
        public async Task<ActionResult<Informacion>> GetContactoItem(string id)

        {
            var contactoItem = await _context.ContactoItems.FindAsync(id);
            if (contactoItem == null)
            {
                return NotFound();
            }
            return contactoItem;
        }




        // POST api/<LogInController>
        [HttpPost]
    public void Post([FromBody] string value)
    {
    }

        // PUT api/<LogInController>/5
       
        // DELETE api/<LogInController>/5
        [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
