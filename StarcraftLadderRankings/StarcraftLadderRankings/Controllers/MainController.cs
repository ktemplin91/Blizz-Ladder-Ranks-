using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarcraftLadderRankings.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult StarcraftRemastered()
        {
            return View();
        }

        public ViewResult StarcraftII()
        {
            return View();
        }

        public ViewResult WoW()
        {
            return View();
        }

        public ViewResult DiabloIII()
        {
            return View();
        }

        public ViewResult HeroesOfTheStorm()
        {
            return View();
        }

        public ViewResult Overwatch()
        {
            return View();
        }

    }
}