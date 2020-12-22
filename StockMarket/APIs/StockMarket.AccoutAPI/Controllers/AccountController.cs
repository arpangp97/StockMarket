using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.AccoutAPI.Services;
using StockMarket.AccoutAPI.Models;
namespace StockMarket.AccoutAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        UserService service = new UserService();
        [HttpGet]
        [Route("Login/{Uname}/{Pwd}")]
        public IActionResult Login(string Uname,string Pwd)
        {
            Token t = service.Login(Uname, Pwd);
            if (t != null)
                return Ok(t);
            else
                return NotFound("Invalid User Credentails");
        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(User item)
        {
            return Ok();
        }
    }
}
