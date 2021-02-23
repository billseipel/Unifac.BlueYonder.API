using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Unifac.BlueYonder.Library.MocaHelper
{
    public class MocaDataHelper: IMocaDataHelper
    {
        private readonly IConfiguration configuration;

        public MocaDataHelper(IConfiguration configuration) {
            this.configuration = configuration;
        }

        public async Task<string> GetDataFromAQuery(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentException("the query was not specified", nameof(query));
            }

            //Put this into the BlueYonder Library class
            var mocaurl = configuration["JDA-MOCA:rootpath"] + configuration["JDA-MOCA:apipath"];

            
            var stringContent = new StringContent(query, Encoding.UTF8, "application/moca-xml");

            string mocaresult;

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync(mocaurl, stringContent);

                var data = await response.Content.ReadAsStringAsync();

                mocaresult = data;
            };


            return mocaresult;
        }




    }
}
