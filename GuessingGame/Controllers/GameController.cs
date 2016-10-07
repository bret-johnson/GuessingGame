using GuessingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessingGame.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            Session["Answer"] = new Random().Next(1, 10);

            return View();
        }

        private bool GuessWasCorrect(int guess)
        {
            return guess == (int)Session["Answer"];
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(GameModel Model)
        {

            if (ModelState.IsValid)
            {
                ViewBag.Win = GuessWasCorrect(Model.Guess);  
            }

            return View(Model);
        }

    }
}


