using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    public class UserResponsityController : BaseApiController
    {
        public readonly IUserResposity _userResposity;
        public UserResponsityController(IUserResposity userResposity)
        {
            _userResposity = userResposity;
        }
        [HttpGet]
        public IActionResult GetAllUser(string search)
        {
            try 
            {
                var result = _userResposity.GetAll(search);
                return Ok(result);
            }
            catch
            {
                return BadRequest("We can't find user");
            }
        }
    }
}