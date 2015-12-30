using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Web.Models;

namespace Quiron.LojaVirtual.Web.HtmlHelpers
{
    public static class paginacaoHelper
    {
        /*Método responsável por gerar o Html Helper que gerenciará a paginação
         Fazendo uma extension ->"this Htmlhelper"
         * Passando a classe paginação
         * Utilizando um delegate ->func<int, string> que recebe dois parâmetros necessarios a construção da paginação 
         
         */
        public static MvcHtmlString pageLinks(this HtmlHelper html, Paginacao paginacao, Func<int, string> paginaUrl)
        {
            //Criando as tags da paginação
            //1 º Passo, isntanciando um stringbuilder responsável pelo resultado
            StringBuilder resultado = new StringBuilder();

            //2º Passo construção da estrutura de repetição for que executará o bloco de código enquanto i for menor que o total de páginas
            for (int i = 1; i <= paginacao.TotalPaginas; i++)
            {
                /* 3º Passo: Instanciando a Classe TagsBuilder e passando 
                      Como parâmetro a tag <a/>
                 */
                TagBuilder tags = new TagBuilder("a");
                /*
                   4º Passo: Adicionando um atributo a tag <a/> 
                 *           E adicionando o conteúdo da variável i 
                 *           ao Delegate responsável pela montagem da paginação
                 */
                tags.MergeAttribute("href", paginaUrl(i));
                /* 
                 * 5º Passo: Inserindo um rótulo que fica após o Href
                 
                 */

                tags.InnerHtml = i.ToString();

                /*
                 6º Paso: Se a navegação estiver na pagina atual, o botão mudará a cor
                 */
                if (i == paginacao.PaginaAtual)
                {
                    
                    tags.AddCssClass("selected");
                    tags.AddCssClass("btn-primary");
                }
                tags.AddCssClass("btn btn-default");
                resultado.Append(tags);

            }
            //Gerando os helpers referentes à Paginação
            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}