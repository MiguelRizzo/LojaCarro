using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppautomovel3.Models;

namespace WebAppautomovel3.Controllers
{
    public class AutomoveisController : Controller
    {
        private ModelBDAutomovel db = new ModelBDAutomovel();

        [HttpPost]
        public ActionResult AddItem(int Id,int Quantidade)
        {
            Automovel auto = db.Automoveis.Find(Id);
            Item item = new Item();
            item.Automovel = auto;
            item.Quantidade = Quantidade;
            item.ValorUnitario = auto.Valor;
            ((Carrinho)HttpContext.Session["Carrinho"]).AddItem(item);

            return RedirectToAction("Details", new { Id = Id });
        }

        // GET: Automoveis
        public ActionResult Index()
        {
            return View(db.Automoveis.ToList());
        }

        // GET: Automoveis/Details/5

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automovel automovel = db.Automoveis.Find(id);
            if (automovel == null)
            {
                return HttpNotFound();
            }
            Item item = new Item();
            item.Quantidade = 1;
            item.Automovel = automovel;
            return View(item);
        }

        // GET: Automoveis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Automoveis/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAutomovel,Modelo,Serie,Cor,Ano,Motor,Foto")] Automovel automovel)
        {
            if (ModelState.IsValid)
            {
                db.Automoveis.Add(automovel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(automovel);
        }

        // GET: Automoveis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automovel automovel = db.Automoveis.Find(id);
            if (automovel == null)
            {
                return HttpNotFound();
            }
            return View(automovel);
        }

        // POST: Automoveis/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAutomovel,Modelo,Serie,Cor,Ano,Valor,Motor,Foto")] Automovel automovel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(automovel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(automovel);
        }

        // GET: Automoveis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automovel automovel = db.Automoveis.Find(id);
            if (automovel == null)
            {
                return HttpNotFound();
            }
            return View(automovel);
        }

        // POST: Automoveis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Automovel automovel = db.Automoveis.Find(id);
            db.Automoveis.Remove(automovel);
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
