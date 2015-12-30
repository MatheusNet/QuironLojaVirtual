using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Web.Models;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        //Isntanceando o repositorio responsável pelos produtos
        private ProdutoRepositorio _repositorio;
        public int produtosPorPagina = 5;

        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)
        {

            _repositorio = new ProdutoRepositorio();

            ProdutoViewModel model = new ProdutoViewModel
            {
                //Retornando uma coleção de produtos e ordenando por nome
                Produtos = _repositorio.Produtos.
                   OrderBy(p => p.Nome)
                    //Executando a paginação
                   .Skip((pagina - 1) * produtosPorPagina)
                   .Take(produtosPorPagina),

                Paginacao = new Paginacao
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = produtosPorPagina,
                    ItensTotal = _repositorio.Produtos.Count()
                },


            };


            return View(model);
        }
    }
}