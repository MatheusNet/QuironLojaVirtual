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
        public int produtosPorPagina = 3;

        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)
        {

            _repositorio = new ProdutoRepositorio();
            //Retornando uma coleção de produtos e ordenando por nome
            var produtos = _repositorio.Produtos.
                OrderBy(p => p.Nome)
                //Executando a paginação
                .Skip((pagina - 1) * produtosPorPagina)
                .Take(produtosPorPagina);


            return View(produtos);
        }
    }
}