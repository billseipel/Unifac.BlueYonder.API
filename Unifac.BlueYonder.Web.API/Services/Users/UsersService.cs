using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Mappings.Users;
using Unifac.BlueYonder.Web.API.Models.Users;
using Unifac.BlueYonder.Web.API.Services.Helpers;

namespace Unifac.BlueYonder.Web.API.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly IDataReaderHelper dataReaderHelper;

        public UsersService(IDataReaderHelper dataReaderHelper)
        {
            this.dataReaderHelper = dataReaderHelper;
        }

        public async Task<User> ListUser(string sessionId, string userid, string loginid)
        {
            // Have a whereClause
            var query = QueryBuilders.StandardQueryBuilder.Query(sessionId, Queries.Queries.GetUser(userid, loginid));
            var data = await dataReaderHelper.GetDataFromAQuery<User, UserProfile>(query);
            return data.FirstOrDefault();
        }

        public async Task<List<User>> ListUsers(string sessionId)
        {
            var query = QueryBuilders.StandardQueryBuilder.Query(sessionId, Queries.Queries.Users);
            var data = await dataReaderHelper.GetDataFromAQuery<User, UserProfile>(query);
            return data;
        }

    }
}
