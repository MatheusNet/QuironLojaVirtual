using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutoRepositorio _repositorio;

        // GET: Produtos
        public ActionResult Index()
        {
            //listando os 10 primeiros produtos
            _repositorio = new ProdutoRepositorio();
            var produtos = _repositorio.Produtos.Take(5);


            return View(produtos);
        }
    }
}