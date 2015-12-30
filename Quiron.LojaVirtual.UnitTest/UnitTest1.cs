using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Quiron.LojaVirtual.Web.HtmlHelpers;
using Quiron.LojaVirtual.Web.Models;

namespace Quiron.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Take()
        {
            //Meu primeiro teste unitário
            //Método Take é responsável pela seleção dos primeiros objetos de uma coleção

            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Query que tem como finalidade pegar os 5 primeiros valores de numeros
            var resultado = from num in numeros.Take(5) select num;

            int[] teste = { 5, 4, 1, 3, 9 };

            //Comparando se o resultado é igual ao teste
            CollectionAssert.AreEqual(resultado.ToArray(), teste);

        }

        [TestMethod]

        public void Skip()
        {
            //Método Skip ignora os 5 primeiros elementos de uma coleção

            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var resultado = from num in numeros.Take(5).Skip(2) select num;

            int[] teste = { 1, 3, 9 };

            CollectionAssert.AreEqual(resultado.ToArray(), teste);

        }

        [TestMethod]
        public void TestarSeAPaginacaoEstaFuncionandoCorretamente()
        {
            //Utilizando TDD na Aplicação
            //1º Arrange: Todo teste pasa por uma preparação

            HtmlHelper html = null;

            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensTotal = 28,
                ItensPorPagina = 10
                
            };

            Func<int, string> paginaUrl = i => "Pagina" + i;

            //2º Act : Estimular o sistema a ser testado
            MvcHtmlString resultado = html.pageLinks(paginacao, paginaUrl);


            //3º Assert: Teste propriamente dito
            Assert.AreEqual(
                  @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                 + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                 + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString()
               
                );

        }
    }


}
