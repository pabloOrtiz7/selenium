using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace PruebaTécnicaRedArbor.Tests
{
    public class myTechnicalTest
    {
        private const string url = "www.milanuncios.com";
        public IWebDriver driver;

        [Setup]

        public void Setup()
        {
            driver = new ChromeDriver("C:/Users/Pablo/Downloads/chromedriver_win32/chromedriver.exe");
        }

        [Test]

        public void test()
        {
            MyTechnicalTestPage myTechnicalTestPage = new myTechnicalTestPage();

            driver.manage().window().maximize();
            driver.Navigate().GoToUrl(url);

            //Accepting the cookies policy
            myTechnicalTestPage.acceptAndCloseCookies();

            //Clicking and Typying in the "Searcher"
            myTechnicalTestPage.search();

            //Clicking on the Search button
            myTechnicalTestPage.clickSearchButton();

            //Clicking on the Filter button
            myTechnicalTestPage.clickFilterButton();

            //Clicking on the "Toda España" option
            myTechnicalTestPage.filterLocation();

            //Clicking and Typying on the "Escribe tu provicia o localidad"
            myTechnicalTestPage.fillingLocation();

            //Choosing the first option of the dropwdown
            myTechnicalTestPage.choosingAnOptionInTheDropdown();

            //Clicking on the "Particular" in the "Tipo de vender" option
            myTechnicalTestPage.choosingParticularOptions();

            //Clicking on the "Ver x anuncios" button
            myTechnicalTestPage.verAnuncios();

            //From this step, I couldn't reproduce the exact scenario because I had 0 results but I typed what I thought the test should be.
            //Clicking on the result option
            myTechnicalTestPage.typeProduct()

            //Assert to assure that the product location is Esparreguera
            myTechnicalTestPage.productLocationAssert();

            //Clicking on the "Message" button
            myTechnicalTestPage.clickOnTheMessageButton();

            //Clicking on the "Continuar con email" button
            myTechnicalTestPage.clickOnTheWithEmailOption();

            //The form is not the same as the guide of the test, so the next steps are fake
            //Filling the form:
            myTechnicalTestPage.fillingMessageForm();

        }

        [TearDown]
        public void CleanupScript()
        {
            driver.Quit();
        }
    }
}
