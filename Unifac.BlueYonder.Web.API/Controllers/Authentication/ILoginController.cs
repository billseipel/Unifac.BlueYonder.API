using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Models;
using Unifac.BlueYonder.Web.API.Models.Authentication;

namespace Unifac.BlueYonder.Web.API.Controllers.Authentication
{
    public interface ILoginController
    {
        public ActionResult<Login> Login(string username, string password);
    }
}
