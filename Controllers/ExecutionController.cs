using IAMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IAMS.Controllers
{
    public class ExecutionController : Controller
    {
        private readonly ILogger<ExecutionController> _logger;
        private readonly TopMenus tm = new TopMenus();
        private readonly DBConnection dBConnection = new DBConnection();

        public ExecutionController(ILogger<ExecutionController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }

        public IActionResult AnnexureB()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult AnnexureB_2()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult AnnexureB_3()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }

        public IActionResult AnnexureB_4()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult AnnexureB_5()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult AnnexureB_6()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }

        public IActionResult AnnexureB_7()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult AnnexureB_8()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult engagement_plan()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["AuditDepartments"] = dBConnection.GetDepartments(354);
            ViewData["DivisionsList"] = dBConnection.GetDivisions(false);
            ViewData["AuditZonesList"] = dBConnection.GetZones();
            return View();
        }

        public IActionResult audit_observation()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
            ViewData["RISK_GROUPS"] = dBConnection.GetRiskGroup();
            return View();
        }
        [HttpPost]
        public List<RiskSubGroupModel> risk_sub_group(RiskGroupModel rgm)
        {
            return dBConnection.GetRiskSubGroup(rgm.GR_ID);
        }
        [HttpPost]
        public List<RiskActivityModel> risk_activities(RiskSubGroupModel rsg)
        {
            return dBConnection.GetRiskActivities(rsg.S_GR_ID);
        }
        [HttpPost]
        public List<AuditObservationTemplateModel> audit_observation_template(RiskActivityModel ra)
        {
            return dBConnection.GetAuditObservationTemplates(ra.ACTIVITY_ID);
        }

        public IActionResult Task_list()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages(); 
            return View();
        }
        public IActionResult audit_execution()
        {
            ViewData["TopMenu"] = tm.GetTopMenus();
            ViewData["TopMenuPages"] = tm.GetTopMenusPages();
             return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
