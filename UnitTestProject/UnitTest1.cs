using Microsoft.VisualStudio.TestTools.UnitTesting;
using EADCAThree;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EADCAThree.Pages.Index.Article article1 = new EADCAThree.Pages.Index.Article();
            EADCAThree.Pages.Index.Article article2 = new EADCAThree.Pages.Index.Article();

            string title = "title1";
            article1.title = title;
            article2.title = title;



            Assert.AreEqual(article1.title, article2.title);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestMethod2Async()
        {
            EADCAThree.Pages.Index indexPage1 = new EADCAThree.Pages.Index();
            EADCAThree.Pages.Index indexPage2 = new EADCAThree.Pages.Index();

            indexPage1.setTypeSearch("headLines");
            indexPage1.setISO("ie");
            indexPage1.setCategory("general");
            indexPage1.searchNews();



            indexPage2.setTypeSearch("headLines");
            indexPage2.setISO("ie");
            indexPage2.setCategory("general");
            
            indexPage2.searchNews();

            indexPage1.getData();
            System.Console.WriteLine(indexPage1.getData());
            Assert.AreEqual(indexPage1.getData(), indexPage2.getData());
        }
    }
}
