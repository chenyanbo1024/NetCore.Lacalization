using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using NetCore.Localization.Models;

namespace NetCore.Localization.Controllers
{
    public class HomeController:Controller
    {
        //public IStringLocalizer<BaseController> _localizer;
        //public HomeController(IStringLocalizer<BaseController> localizer)
        //{
        //    _localizer = localizer;
        //}

        #region 注释
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        #endregion

        public IActionResult Hello()
        {
            return Content(Startup.localizer["chenyanbo"]);
        }
    }
}
