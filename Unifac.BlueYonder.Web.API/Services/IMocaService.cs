using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Models;
using Unifac.BlueYonder.Web.API.Models.Authentication;
using Unifac.BlueYonder.Web.API.Models.Users;

namespace Unifac.BlueYonder.Web.API.Services
{
    public interface IMocaService
    {
        public string sessionId();
        Task<Login> Login(string username, string password);

        
    }
}
