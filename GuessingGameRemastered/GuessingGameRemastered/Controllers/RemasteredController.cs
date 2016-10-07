using GuessingGameRemastered.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessingGameRemastered.Controllers
{
    public class RemasteredController : Controller
    {
        // GET: Remastered
        public ActionResult Index()
        {
            Session["Answer"] = new Random().Next(1, 73);

            return View();
        }
        
        private bool GuessWasCorrect(int guess)
        {
            return guess == (int)Session["Answer"];
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(RemasteredModel Model)
        {

            if(ModelState.IsValid)
            {
                ViewBag.Win = GuessWasCorrect(Model.Guess);
            }

            return View(Model);
        }
    }
}