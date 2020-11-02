using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcCore_323_Project_2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        //
        //Get : /Employee/Welcome/

        public string Welcome()
        {
            return "This is the welcome action method...";
        }
    }
}
