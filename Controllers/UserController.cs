using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginService.Login.contract;
using LoginService.Model;
namespace LoginService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ILogin _login;
        public UserController(ILogin login)
        {
            _login = login;
        }
        [HttpPost]
        public void Post([FromBody] MemberShip value)
        {
           _login.CreateMembership(value);
        }

        [HttpPost("login")]
         public ActionResult PostData([FromBody]MemberShip value)
        {
          var ctr=_login.SignIn(value.username,value.password);
          return Ok(ctr);     
        }
    }

    
}