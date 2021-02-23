using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unifac.BlueYonder.Web.API.Models.Users
{
    public class UserResult
    {
        public Users Users { get; set; }

    }
    public class Users
    {
        public List<User> User { get; set; }

    }

   
}
