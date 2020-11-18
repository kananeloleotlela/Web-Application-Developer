using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcCore_323_Project_2_.Controllers
{
    public class ExecutiveController : Controller
    {
        [Authorize(Roles = "Executive")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
