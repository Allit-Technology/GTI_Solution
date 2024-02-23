using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void MeuHelloWorldTest()
        {
            //a - arrange (ambiente)
            int random = 0;

            do
            {
                random = new Random().Next(10);
            }
            while (random % 2 != 0);


            //a - act (ação do método)
            var ehPar = random % 2 == 0;

            //a - assert (verifica se deu tudo certo)
            Assert.AreEqual(true, ehPar);
        }


    }
}
