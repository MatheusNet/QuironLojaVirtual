using Quiron.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        /* Após a criação do DbContext, o próximo passo é mapear os dados da tabela desejada
         * O Arquivo DbContext é a classe onde ficam todos os DbSet´s
         * 1º Criando uma representação das entidades no contexo com DBSet
         */
        public DbSet<Produto> Produtos { get; set; }


        //Trabalhando com pluraliarção Através do OnModelCreating
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           //Removendo a automarizanção da pluralização no Entity Framework
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           //Criando manualmente a pluralização da tabela produtos
            modelBuilder.Entity<Produto>().ToTable("Produtos");

        }
    }
}
