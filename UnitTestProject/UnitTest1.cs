using Microsoft.VisualStudio.TestTools.UnitTesting;
using EADCAThree;
using System.Threading.Tasks;

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
        public void TestMethod2()
        {
            EADCAThree.Pages.Index indexPage1 = new EADCAThree.Pages.Index();
            EADCAThree.Pages.Index indexPage2 = new EADCAThree.Pages.Index();



            indexPage1.setTypeSearch("everyThing");
            indexPage1.setNewsTopic("bitcoin@");
            indexPage1.searchNews();

            indexPage2.setTypeSearch("everyThing");
            indexPage2.setNewsTopic("bitcoin");
            indexPage2.searchNews();


            Assert.AreEqual(indexPage1.SpecialChar(), true);//since indexPage1 search topic contains @ it should return true 
            Assert.AreEqual(indexPage2.SpecialChar(), false);
        }

        [TestMethod]
        public void TestMethod3()
        {
            EADCAThree.Pages.Index indexPage1 = new EADCAThree.Pages.Index();
            EADCAThree.Pages.Index indexPage2 = new EADCAThree.Pages.Index();
            



            indexPage1.setTypeSearch("headLines");
            indexPage1.setISO("ie");
            indexPage1.setCategory("general");
            indexPage1.searchNews();

            indexPage2.setTypeSearch("everyThing");
            indexPage2.setNewsTopic("bitcoin");
            indexPage2.searchNews();




            Assert.AreEqual(indexPage1.TopHeadLinesBool(), true);
            Assert.AreEqual(indexPage2.SpecialChar(), false);
        }
    }
}
