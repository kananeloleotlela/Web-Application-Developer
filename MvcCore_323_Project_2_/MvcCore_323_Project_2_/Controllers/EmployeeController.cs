﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcCore_323_Project_2_.Controllers
{
    public class EmployeeController : Controller
    {
        [Authorize(Roles = "Employee")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
