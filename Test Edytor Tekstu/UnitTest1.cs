using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Edytor_Tekstu
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestOpenFile()
        {
            Edytor_Tekstowy.Form1 form = new Edytor_Tekstowy.Form1();
            bool check = form.open_file();

            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestSaveFile()
        {
            Edytor_Tekstowy.Form1 form = new Edytor_Tekstowy.Form1();
            form.open_file();
            bool check = form.save_file();

            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestModeChange()
        {
            Edytor_Tekstowy.Form1 form = new Edytor_Tekstowy.Form1();
            bool check = form.mode_change();

            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestSearch()
        {
            Edytor_Tekstowy.Form1 form = new Edytor_Tekstowy.Form1();
            bool check = form.search();

            Assert.AreEqual(true, check);
        }
        [TestMethod]
        public void TestReplace()
        {
            Edytor_Tekstowy.Form1 form = new Edytor_Tekstowy.Form1();
            bool check = form.replace();

            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestNewTekst()
        {
            Edytor_Tekstowy.Form1 form = new Edytor_Tekstowy.Form1();
            form.open_file();
            bool check = form.new_tekst();

            Assert.AreEqual(true, check);
        }
    }
}