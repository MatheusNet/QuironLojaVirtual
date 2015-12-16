using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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

            var resultado = from num in numeros.Take(5) select num;

            int[] teste = { 5, 4, 1, 3, 8 };

            CollectionAssert.AreEqual(resultado.ToArray(), teste);

        }
    }
}
