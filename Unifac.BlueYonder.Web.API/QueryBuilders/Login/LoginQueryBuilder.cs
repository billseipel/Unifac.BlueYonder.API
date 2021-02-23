using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unifac.BlueYonder.Web.API.QueryBuilders.Login
{
    public static class LoginQueryBuilder
    {
        public static string Login(string username, string password)
        {

            var whereClause = $"where usr_id = '{username}' and usr_pswd = '{password}' ";

            var login = $"<moca-request autocommit=\"True\">" +
                $"<environment><var name=\"USR_ID\" value=\"{username}\"/>" +
                $"</environment>" +
                $"<query> login user {whereClause}</query>"+
                $"</moca-request>";

            return login;
        }
    }
}
