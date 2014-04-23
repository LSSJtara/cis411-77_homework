using GameLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GameLibrary.Controllers
{
    public class HomeController : Controller
    {
        private GameLibraryContext db = new GameLibraryContext();

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            // Send users list to home page
            using (var ctx = new UsersContext())
            {
                return View(ctx.UserProfiles.ToList());
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewProfile(string name)
        {
            string currentUser = name;
            return View(db.Games.ToList().Where(game => game.UserName == currentUser));

        }
        
        public ActionResult Details(int id = 0)
        {
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }
    }
}
