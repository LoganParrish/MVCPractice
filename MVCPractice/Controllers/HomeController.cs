﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/Index

        public ActionResult Index()
        {
            return View();
        }

        //Get /Home/About
        public ActionResult About()
        {
            return View();
        }


    }
}
