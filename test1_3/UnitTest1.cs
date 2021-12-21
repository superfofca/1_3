using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_3;

namespace test1_3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Artyr artyr = new Artyr("Артур");
            P p = new P("дыра");
            Enttity enttity = new Enttity("существа");

            Assert.AreEqual("Например, в тот самый момент, когда ", artyr.start());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Artyr artyr = new Artyr("Артур");
            Assert.AreEqual("Артур", artyr.name);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Artyr artyr = new Artyr("Артур");
            Assert.AreEqual("произнес 'А у меня, кажется, большие проблемы с образом жизни', в ткани пространства-времени открылась случайная", artyr.next());
        }

        [TestMethod]
        public void TestMethod4()
        {
            P p = new P("дыра");
            Assert.AreEqual("дыра", p.name);
        }

        [TestMethod]
        public void TestMethod5()
        {
            P p = new P("дыра");
            Assert.AreEqual("и перенесла его слова далеко-далеко во времени через почти бескрайние просторы космоса в далекую галактику, где странные воинственные", p.next2());
        }

        [TestMethod]
        public void TestMethod6()
        {
            Enttity enttity = new Enttity("существа");
            Assert.AreEqual("существа", enttity.name);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Enttity enttity = new Enttity("существа");
            Assert.AreEqual("балансировали на грани ужасной межзвездной войны.", enttity.sushestva());
        }
    }
}
