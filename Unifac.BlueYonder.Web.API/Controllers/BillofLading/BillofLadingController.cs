using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Unifac.BlueYonder.Web.Library;

namespace Unifac.BlueYonder.Web.API.Controllers.BillOfLading
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillofLadingController : ControllerBase
    {
        private readonly ILogger<BillofLadingController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IMocaValidating _class1;

        public BillofLadingController(ILogger<BillofLadingController> logger,
                            IConfiguration configuration,
                            IMocaValidating class1)
        {
            _logger = logger;
            _configuration = configuration;
            _class1 = class1;

        }

        //[HttpGet("{ordnum}")]
        //public async Task<IActionResult> GetBillofLanding(int ordnum)
        //{


        //    var rawxml = $"<moca-request autocommit=\"True\">" +
        //        $"<environment><var name=\"USR_ID\" value=\"SVCMOCAAPI\"/>" +
        //        $"<var name=\"SESSION_KEY\" value=\"{MocaConstants.sessionID}\"/>" +
        //        $"<var name=\"LOCALE_ID\" value=\"US_ENGLISH\"/>" +
        //        $"<var name=\"MOCA_APPL_ID\" value=\"LEXTEDIT\"/>" +
        //        $"</environment><query> rpt bill of lading where ordnum = '" + ordnum + "'</query></moca-request>";


        //    //Put this into the BlueYonder Library class
        //    var mocaurl = _configuration["JDA-MOCA:rootpath"] + _configuration["JDA-MOCA:apipath"];

        //    //Put into the DataHelper?
        //    var stringContent = new StringContent(rawxml, Encoding.UTF8, "application/moca-xml");

        //    string mocaresult;

        //    using (var httpClient = new HttpClient())
        //    {
        //        var response = await httpClient.PostAsync(mocaurl, stringContent);

        //        var data = await response.Content.ReadAsStringAsync();

        //        mocaresult = data;
        //    };

        //    //Mapping the result
        //    return new JsonResult(_class1.GetData(mocaresult));


        //}

        //[HttpGet]
        //public async Task<IActionResult> GetBillofLanding()
        //{
        //    var rawxml = $"<moca-request autocommit=\"True\">" +
        //        $"<environment><var name=\"USR_ID\" value=\"SVCMOCAAPI\"/>" +
        //        $"<var name=\"SESSION_KEY\" value=\"{MocaConstants.sessionID}\"/>" +
        //        $"<var name=\"LOCALE_ID\" value=\"US_ENGLISH\"/>" +
        //        $"<var name=\"MOCA_APPL_ID\" value=\"LEXTEDIT\"/>" +
        //        $"</environment><query> rpt bill of lading </query></moca-request>";


        //    var mocaurl = _configuration["JDA-MOCA:rootpath"] + _configuration["JDA-MOCA:apipath"];

        //    var stringContent = new StringContent(rawxml, Encoding.UTF8, "application/moca-xml");

        //    string mocaresult;

        //    using (var httpClient = new HttpClient())
        //    {
        //        var response = await httpClient.PostAsync(mocaurl, stringContent);

        //        var data = await response.Content.ReadAsStringAsync();

        //        mocaresult = data;
        //    };


        //    return new JsonResult(_class1.GetData(mocaresult));


        //}
    }
}

