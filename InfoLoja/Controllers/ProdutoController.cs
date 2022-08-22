using InfoLoja.Context;
using InfoLoja.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace InfoLoja.Controllers
{
   
    public class ProdutosController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Produtos
        public ActionResult Index()
        {
            var produtos =
            context.Produtos.Include(d => d.Departamento).
            OrderBy(n => n.Nome);   
            return View(produtos);
        }
        // GET: Produtos/Create
        public ActionResult Create()
        {
           
            ViewBag.DepartamentoId = new SelectList(context.Departamentos.OrderBy(b => b.Nome),
            "DepartamentoId", "Nome");
            return View();
        }
        // POST: Produtos/Create
        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            try
            {
                // TODO: Add insert logic here
                context.Produtos.Add(produto);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(produto);
            }
        }
        // GET: Produtos/Edit/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = context.Produtos.Where(p => p.ProdutoId == id).Include(d => d.Departamento).First();
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }
    }
    }