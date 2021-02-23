using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unifac.BlueYonder.Web.API.Controllers.Authentication;
using Unifac.BlueYonder.Web.API.Mappings;
using Unifac.BlueYonder.Web.API.Mappings.Authentication;
using Unifac.BlueYonder.Web.API.Mappings.Users;
using Unifac.BlueYonder.Web.API.Models;
using Unifac.BlueYonder.Web.API.Models.Authentication;
using Unifac.BlueYonder.Web.API.Models.Users;
using Unifac.BlueYonder.Web.API.Services.Helpers;
using Unifac.BlueYonder.Web.API.Services.Users;

namespace Unifac.BlueYonder.Web.API.Services
{
    public class MocaService : IMocaService
    {
        private readonly IDataReaderHelper dataReaderHelper;
        private readonly IConfiguration configuration;
        private readonly IUsersService usersService;
        

        public MocaService(IDataReaderHelper dataReaderHelper
            , IConfiguration config
            , IUsersService usersService)
        {
            this.dataReaderHelper = dataReaderHelper;
            this.configuration = config;
            this.usersService = usersService;
        }

        public string sessionId()
        {
            Login loginresult = Login(this.configuration["JDA-MOCA:username"], this.configuration["JDA-MOCA:password"]).Result;
            var sessionId = loginresult.SessionId;
            return sessionId;
        }

       // Used by the API
        public async Task<Login> Login(string username, string password)
        {
            var query = QueryBuilders.Login.LoginQueryBuilder.Login(username, password);
           // The GetDataFromAQuery could return multiple results
            var data = await dataReaderHelper.GetDataFromAQuery<Login, LoginProfile>(query);
            // We only care about the FIRST result
            return data.FirstOrDefault();
           
        }
    }
}
