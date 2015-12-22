using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        //Todos os itens do BD
        public int ItensTotal { get; set; }
        //Quantos itens por página
        public int ItensPorPagina { get; set; }
        //Qual é a página atual
        public int  PaginaAtual { get; set; }

        /*
         Para retornar o total de páginas, será necessária uma divisão
         * do ItensTotal por ItensPOrPagina
         * A Divisão dos dois não poderá ser quebrada, então para garantir isto, seu resultado será sempre arredondado para cima
         * Através do método Math.Cieling
         */
        public int TotalPaginas
        {
            get
            {
                return (int) Math.Ceiling((decimal)
                    ItensTotal/ItensPorPagina);
            }

        }
    }
}