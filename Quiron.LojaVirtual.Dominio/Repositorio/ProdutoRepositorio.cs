using Quiron.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutoRepositorio
    {
        /*Criando o repositório responsável pelos produtos
         * O repositório é a classe responsável por manipular todos os dados, utilizando o DbContext
         1º Passo: referenciando o Entity Framework
         */

        private readonly EfDbContext _context = new EfDbContext();

        //2º Passo: Criando um objeto do tipo IEnurable com a finalidade de retornar os produtos

        public IEnumerable<Produto> Produtos
        {

            get { return _context.Produtos; }
        }
        
   }
}
