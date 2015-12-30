using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Web.Models
{
    public class ProdutoViewModel
    {
        /*
         Uma ViewM0del, é uma classe que atende especificamente a uma view
         * Nesse caso, ela será utilizada para suprir a view Vitrine
         * Trazendo para ela, todos os produtos, junto a estrutura da paginação!
         
         */
        public IEnumerable<Produto> Produtos { get; set; }

        public Paginacao Paginacao { get; set; }
    }
}