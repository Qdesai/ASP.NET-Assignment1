using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelMonitors.Controllers
{
    public class MonitorsListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
