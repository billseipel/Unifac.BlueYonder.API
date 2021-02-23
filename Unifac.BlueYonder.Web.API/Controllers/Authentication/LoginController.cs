using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Unifac.BlueYonder.Web.API.Models;
using Unifac.BlueYonder.Web.API.Models.Authentication;
using Unifac.BlueYonder.Web.API.Services;

namespace Unifac.BlueYonder.Web.API.Controllers.Authentication
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase, ILoginController
    {
        private readonly IMocaService mocaService;
        public LoginController(IMocaService mocaService) {
            this.mocaService = mocaService;
        }

        [HttpPost]
        public ActionResult<Login> Login(string username, string password)
        {
            var result = mocaService.Login(username, password).Result;

            return result;
        }
        


    }
}
