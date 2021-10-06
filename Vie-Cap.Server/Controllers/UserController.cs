using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Vie_Cap.Server.Database;
using Vie_Cap.Server.Tools;
using Vie_Cap.Shared;

namespace Vie_Cap.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IAuthRrpository _authRrpo;

        private readonly DataContext _context;
        public UserController(DataContext dataContext , IAuthRrpository authRrpository)
        {
            _context = dataContext;
            _authRrpo = authRrpository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var User = _context.Users.FirstOrDefault(u => u.User_ID == id);
            if (User == null)
            {
                return NotFound("Not Found User");
            }

            return Ok(User);
        }




        [HttpPut("User")]
        public async Task<IActionResult> Put([FromBody] UpdateUser users  , int id )
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.User_ID == id);
            //  var user = await _utilityService.GetUser();
            user.C_ID = 1;// users.C_ID;
            user.JopTitle = users.JopTitle;
            user.OwnerShip = users.OwnerShip;
            user.ImageUrl = users.ImageUrl;
            users.State = users.State;
            user.Phone = users.Phone;
            user.Address = users.Address;
            user.National_ID = users.National_ID;
            user.ZipCode = user.ZipCode;
            await _context.SaveChangesAsync();


            return Ok(user);

        }











        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutUser(int id ,User user)
        //{
        //    var User = _context.Users.FirstOrDefault(u => u.User_ID == id);
        //    if (User == null)
        //    {
        //        return NotFound("Not Found User");
        //    }

        //    return Ok(User);
        //}

        //[HttpPost]
        //public async Task<IActionResult> PostUser(Company company, int u_id)
        //{

        //    company.User_ID = u_id;
        //    _context.Companies.Add(company);
        //    _context.SaveChanges();


        //    List<Vie_Cap.Shared.User> users = new List<User>();
        //    foreach (var item in users)
        //    {

        //        Vie_Cap.Shared.User us = _context.Users.Find(u_id);
        //        item.User_ID = u_id;
        //        item.PasswordHash = us.PasswordHash;
        //        item.PasswordSalt = us.PasswordSalt;
        //        item.IsConfirmed = item.IsConfirmed;
        //        _context.Entry(us).State = EntityState.Modified;
        //        _context.SaveChanges();

        //    }


        //    return Ok(company);
        //}



        // PUT: api/Centers/5
        // [HttpPut]
        //public async Task<IActionResult> PutCenter(int id, User user)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != user.User_ID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(user).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UserExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return Ok(user);
        //}



        //private bool UserExists(int id)
        //{
        //    return _context.Users.Count(e => e.User_ID == id) > 0;
        //}

        //public async void Put(int id, [FromBody] User us)
        //{

        //        var entity = _context.Users.FirstOrDefault(e => e.User_ID == id);

        //        entity.FirstName = us.FirstName;
        //        entity.LastName = us.LastName;
        //        entity.PasswordHash = us.PasswordHash;
        //        entity.PasswordSalt = us.PasswordSalt;
        //    entity.Phone = us.Phone;
        //        await _context.SaveChangesAsync();

        //}

        //[HttpPut]
        //public async  Task<IActionResult> Putuser(int id, [FromBody] User us)
        //{
        //    try
        //    {

        //            var entity = _context.Users.FirstOrDefault(e => e.User_ID == id);
        //            if (entity == null)
        //            {
        //            return NotFound("Employee with Id " + id.ToString() + " not found to update");
        //            }
        //            else
        //            {
        //            entity.FirstName = us.FirstName;
        //            entity.LastName = us.LastName;
        //            entity.PasswordHash = us.PasswordHash;
        //            entity.PasswordSalt = us.PasswordSalt;
        //            entity.Phone = us.Phone;

        //            await _context.SaveChangesAsync();

        //                return  Ok(entity);
        //            }

        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest();
        //    }
        // }




    }

}
