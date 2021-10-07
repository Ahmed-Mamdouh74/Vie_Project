using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class CompanyController : ControllerBase
    {
        private readonly DataContext _context;

        public CompanyController(DataContext dataContext)
        {
            _context = dataContext;
            
        }
        [HttpPost]
        public async Task<IActionResult>PostCompany(ModeViewCompany company)
        {
            Company comp = new Company();
          
            comp.Address = company.Address;
            comp.Company_Name = company.Company_Name;
            comp.Describe = company.Describe;
            comp.Legal_Bussiness = company.Legal_Bussiness;
            comp.Major = company.Major;
            comp.Phone = company.Phone;
            comp.Web_Site = company.Web_Site;
            comp.User_ID = company.User_ID;
            comp.C_ID = company.C_ID;
            comp.Isvolved = true;
            comp.A_Id = company.A_Id;
            

            _context.Companies.Add(comp);
            await  _context.SaveChangesAsync();
            return Ok(company);
        }

    }
}
