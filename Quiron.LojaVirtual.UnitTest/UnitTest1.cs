using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

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

            int [] numeros = {5,4,1,3,9,8,6,7,2,0};
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

            int[] numeros = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var resultado = from num in numeros.Take(5).Skip(2) select num;

            int[] teste = {1, 3, 9};

            CollectionAssert.AreEqual(resultado.ToArray(), teste);

        }
    }

    
}
