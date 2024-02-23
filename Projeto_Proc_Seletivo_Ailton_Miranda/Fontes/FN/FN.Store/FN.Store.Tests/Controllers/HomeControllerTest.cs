using FN.Store.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FN.Store.Tests.Controllers
{
    [TestCategory("Controllers")]
    [TestClass]
    public class HomeControllerTest
    {
        //dado um homecontroller

        [TestMethod]
        public void DeveraRetornarAViewIndex()
        {
            //arrange
            var homeController = new HomeController();

            //act
            //var result = (ViewResult)homeController.Index();
            //as = tenta converter, e se não conseguir, resulta em null
            var result = homeController.Index() as ViewResult;

            //assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());

        }

    }
}
