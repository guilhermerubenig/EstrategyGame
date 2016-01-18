using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StrategyGame.Models;

namespace StrategyGame.Controllers.Home
{
    public class AccountController : Controller
    {
        private StrategyGameEntities db = new StrategyGameEntities();

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include= "Email_GMR, Senha_GMR")] Gamer ga)
        {

            Gamer gamer = db.Gamer.Where(g => g.Email_GMR == ga.Email_GMR && g.Senha_GMR == ga.Senha_GMR && g.Ativo_GMR == true).FirstOrDefault();

            if (gamer != null)
            {
                Session["GamerID"] = gamer.ID;

                return RedirectToAction("Edit", "Gamers");
            }
            else
            {
                gamer = new Gamer();
                gamer.Email_GMR = "";
                gamer.Senha_GMR = "";
                gamer.Mensagem = "Gamer não foi localizado ou não está ativo.";
            }

            return View(gamer);
        }
    }
}