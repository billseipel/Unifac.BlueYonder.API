
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Unifac.BlueYonder.Web.API.Controllers.Authentication;
using System.Collections.Generic;
using Unifac.BlueYonder.Web.API.Models.Users;
using Unifac.BlueYonder.Web.API.Models.Authentication;
using Newtonsoft.Json;
using Unifac.BlueYonder.Web.API.Services;
using Unifac.BlueYonder.Web.API.Services.Users;

namespace Unifac.BlueYonder.Web.API.Controllers.Users
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> logger;
        private readonly IMocaService mocaService;
        private readonly IUsersService usersService;

        public UsersController(ILogger<UsersController> logger
            , IUsersService usersService
            , IMocaService mocaService)
        {
            this.logger = logger;
            this.usersService = usersService;
            this.mocaService = mocaService;
        }
       
        [HttpGet]
        public ActionResult<List<User>> ListUsers()
        {
            //Note: calling sessionId method will login when called
            var result = usersService.ListUsers(mocaService.sessionId()).Result;
            return result;
        }

        //Url will look like: http://[domain]/api/users/SVCMOCAAPI?loginid=SVCMOCAAPI
        [HttpGet("{userid}")]
        public ActionResult<User> ListUser(string userid, string loginid = null)
        {
            //Note: calling sessionId method will login when called
            var result = usersService.ListUser(mocaService.sessionId(), userid, loginid).Result;
            return result;

        }
    }
}
