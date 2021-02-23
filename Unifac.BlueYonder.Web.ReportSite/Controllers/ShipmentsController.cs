using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unifac.BlueYonder.Web.ReportSite.Models.Shipments;

namespace Unifac.BlueYonder.Web.ReportSite.Controllers
{
    public class ShipmentsController : Controller
    {
        public IActionResult Index(ShipmentsModel shipmentModel)
        {
            return View(shipmentModel);
        }
    }
}
