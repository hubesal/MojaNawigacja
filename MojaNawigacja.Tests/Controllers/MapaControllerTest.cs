using Microsoft.VisualStudio.TestTools.UnitTesting;
using MojaNawigacja.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaNawigacja.Tests.Controllers
{
    [TestClass]
    public class MapaControllerTest
    {
        [TestMethod]
        public void SprawdzMape()
        {
            var mapaController = new MapaController();
            var ViewResult = mapaController.Index();
            Assert.IsNotNull(ViewResult);
        }

    }
}
