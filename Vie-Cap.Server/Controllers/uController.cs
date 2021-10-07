using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vie_Cap.Server.Database;
using Vie_Cap.Shared;

namespace Vie_Cap.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class uController : ControllerBase
    {
        private readonly DataContext _context;
        public uController(DataContext dataContext)
        {
            _context = dataContext;
           
        }
        [HttpGet]
        public IEnumerable<Vie_Cap.Shared.User> GetUserMasters()
        {
            return _context.Users;
        }



        // GET: api/StudentMasters/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsertMasters([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var UsertMasters = await _context.Users.FindAsync(id);

            if (UsertMasters == null)
            {
                return NotFound();
            }

            return Ok(UsertMasters);
        }




        // PUT: api/StudentMasters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentMasters([FromRoute] int id, [FromBody] User userMasters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userMasters.User_ID)
            {
                return BadRequest();
            }

            _context.Entry(userMasters).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!userMastersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        // POST: api/StudentMasters
        [HttpPost]
        public async Task<IActionResult> PostStudentMasters([FromBody] User studentMasters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Users.Add(studentMasters);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsertMasters", new { id = studentMasters.User_ID }, studentMasters);
        }


        private bool userMastersExists(int id)
        {
            return _context.Users.Any(e => e.User_ID == id);
        }









    }
}
