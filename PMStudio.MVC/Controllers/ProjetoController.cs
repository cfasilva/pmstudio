using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PMStudio.MVC.Models;

namespace PMStudio.MVC.Controllers
{
    public class ProjetoController : Controller
    {
        private PMStudioContext db = new PMStudioContext();

        // GET: /Projeto/
        public ActionResult Index()
        {
            var projetos = db.Projetos.Include(p => p.Cliente).Include(p => p.TiposProjetos);
            return View(projetos.ToList());
        }

        // GET: /Projeto/Create
        public ActionResult Create()
        {
            ViewBag.IdCliente = new SelectList(db.Clientes, "Id", "Nome");
            ViewBag.IdTipoProjeto = new SelectList(db.TiposProjetos, "Id", "Descricao");
            return View();
        }

        // POST: /Projeto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,IdTipoProjeto,IdCliente,Identificador,Nome,Justificativa,Objetivo,Prazo,Custo,Descricao,Meta,DtCadastro,DtAtualizacao,DtInicio,DtFim,Login,Situacao")] Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                db.Projetos.Add(projeto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCliente = new SelectList(db.Clientes, "Id", "Nome", projeto.IdCliente);
            ViewBag.IdTipoProjeto = new SelectList(db.TiposProjetos, "Id", "Descricao", projeto.IdTipoProjeto);
            return View(projeto);
        }

        // GET: /Projeto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projeto projeto = db.Projetos.Find(id);
            if (projeto == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCliente = new SelectList(db.Clientes, "Id", "Nome", projeto.IdCliente);
            ViewBag.IdTipoProjeto = new SelectList(db.TiposProjetos, "Id", "Descricao", projeto.IdTipoProjeto);
            return View(projeto);
        }

        // POST: /Projeto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,IdTipoProjeto,IdCliente,Identificador,Nome,Justificativa,Objetivo,Prazo,Custo,Descricao,Meta,DtCadastro,DtAtualizacao,DtInicio,DtFim,Login,Situacao")] Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projeto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCliente = new SelectList(db.Clientes, "Id", "Nome", projeto.IdCliente);
            ViewBag.IdTipoProjeto = new SelectList(db.TiposProjetos, "Id", "Descricao", projeto.IdTipoProjeto);
            return View(projeto);
        }

        // GET: /Projeto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projeto projeto = db.Projetos.Find(id);
            if (projeto == null)
            {
                return HttpNotFound();
            }
            return View(projeto);
        }

        // POST: /Projeto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Projeto projeto = db.Projetos.Find(id);
            db.Projetos.Remove(projeto);
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