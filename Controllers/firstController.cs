﻿using Microsoft.AspNetCore.Mvc;
using Mission1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission1.Controllers
{
    public class firstController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
        [HttpGet]
        public IActionResult gradecalc ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult gradecalc(GradeCalcModel model)
        {
            return View();
        }
    }
}
