using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StrategyGame.Models;

namespace StrategyGame.Controllers
{
    public class GamersController : Controller
    {
        private StrategyGameEntities db = new StrategyGameEntities();

        // GET: Gamers
        public ActionResult Index()
        {
            return View(db.Gamer.ToList());
        }

        // GET: Gamers/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                id = Convert.ToInt32(Session["GamerID"]);
            }


            if (id == null) 
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gamer gamer = db.Gamer.Find(id);
            if (gamer == null)
            {
                return HttpNotFound();
            }
            return View(gamer);
        }

        // GET: Gamers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gamers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome_GMR,Sobrenome_GMR,Apelido_GMR,DataNascimento_GMR,Ativo_GMR,Email_GMR,Nacionalidade,Sexo_GMR,Youtube_GMR,Twitter_GMR,Twitch_GMR,Facebook_GMR,Fone_GMR,Imagem_GMR,Senha_GMR,Positividade,Negatividade,Juiz_GMR")] Gamer gamer)
        {
            if (ModelState.IsValid)
            {
                gamer.DataCadastro_GMR = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                gamer.Fone_GMR = null;

                db.Gamer.Add(gamer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gamer);
        }

        // GET: Gamers/Edit/5
        public ActionResult Edit(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            if (id == null)
            {
                id = Convert.ToInt32(Session["GamerID"]);
            }
            
            Gamer gamer = db.Gamer.Find(id);
            if (gamer == null)
            {
                return HttpNotFound();
            }
            return View(gamer);
        }

        // POST: Gamers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Gamer gamer)
        {
            if (ModelState.IsValid)
            {
                gamer.ID = Convert.ToInt32(Session["GamerID"]);
                
                db.Entry(gamer).State = EntityState.Modified;
                db.SaveChanges();
                //return RedirectToAction("Edit");
            }
            return View(gamer);
        }

        // GET: Gamers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gamer gamer = db.Gamer.Find(id);
            if (gamer == null)
            {
                return HttpNotFound();
            }
            return View(gamer);
        }

        // POST: Gamers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gamer gamer = db.Gamer.Find(id);
            db.Gamer.Remove(gamer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
