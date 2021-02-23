using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Models.Users;

namespace Unifac.BlueYonder.Web.API.Services.Users
{
    public interface IUsersService
    {
        Task<List<User>> ListUsers(string sessionId);

        Task<User> ListUser(string sessionId, string userid, string loginid);
    }
}
