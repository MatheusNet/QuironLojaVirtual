using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        //Isntanceando o repositorio responsável pelos produtos
        private ProdutoRepositorio _repositorio;


        // GET: Vitrine
        public ActionResult Index()
        {
           
            _repositorio = new ProdutoRepositorio();
            //Retornando uma coleção de produtos
            var produtos = _repositorio.Produtos;
            

            return View();
        }
    }
}