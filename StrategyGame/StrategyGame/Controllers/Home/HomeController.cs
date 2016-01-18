using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StrategyGame.Models;

namespace StrategyGame.Controllers.Home
{
    public class HomeController : Controller
    {
        private StrategyGameEntities db = new StrategyGameEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CadastrarGamer(string apelido, string email, string senha)
        {
            string retorno = this.Cadastrar(apelido, email, senha);

            return Json(new
            {
                Retorno = retorno,

            });
        }

        //Cadastrar Gamer pela Home
        public string Cadastrar(string apelido, string email, string senha)
        {
            string retorno = string.Empty;
            //Verifica se o email já foi cadastrado
            Gamer gamer = db.Gamer.Where(g => g.Email_GMR == email).FirstOrDefault();

            if (gamer == null)
            {
                gamer = new Gamer();
                gamer.Apelido_GMR = apelido;
                gamer.Email_GMR = email;
                gamer.Senha_GMR = senha;
                gamer.DataCadastro_GMR = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                gamer.Juiz_GMR = true;
                gamer.Ativo_GMR = true;

                db.Gamer.Add(gamer);
                db.SaveChanges();

                //Criar método de envio de e-mail

                retorno = "C";
            }
            else
            {
                retorno = "Existe";
            }

            return retorno;

        }
    }
}