﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StarLiberi.Controllers
{
    public class AbaPaisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}