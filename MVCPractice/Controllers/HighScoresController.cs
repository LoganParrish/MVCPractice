using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class HighScoresController : Controller
    {
        //
        // GET: /HighScores/

        public ActionResult Index()
        {
            return View();
        }

    }
}
