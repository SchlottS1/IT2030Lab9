using System;
using NFLTeams.Models;
using Microsoft.AspNetCore.Mvc;

namespace NFLTeams.Controllers
{
    public class NameController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var session = new NFLSession(HttpContext.Session);
            var model = new TeamListViewModel
            {
                ActiveConf = session.GetActiveConf(),
                ActiveDiv = session.GetActiveDiv(),
                Teams = session.GetMyTeams(),
                UserName = session.GetName()
            };

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Change(TeamListViewModel model)
        {
            var session = new NFLSession(HttpContext.Session);
            session.SetName(model.UserName);
            return RedirectToAction("Index", "Home", new
            {
                ActiveConf = session.GetActiveConf(),
                ActiveDiv = session.GetActiveDiv()
            });
        }
    }
}
