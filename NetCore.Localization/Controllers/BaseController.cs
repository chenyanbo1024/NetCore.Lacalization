using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace NetCore.Localization.Controllers
{
    public class BaseController : Controller
    {
        public IStringLocalizer<BaseController> _localizer;
        public BaseController(IStringLocalizer<BaseController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}