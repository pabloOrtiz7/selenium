using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTécnicaRedArbor.Source.Pages
{
    public class myTechnicalTestPage
    {
        IWebElement acceptAndCloseButton = driver.FindElement(By.Id("TcfAccept"));
        public void acceptAndCloseCookies() 
        { 
            acceptAndCloseButton.Click(); 
        }

        IWebElement searcherField = driver.FindElement(By.Id("form-search-suggester-input"));
        public void search()
        { 
            searcherField.Click();
            searcherField.SendKeys("Stores amarillos");
        }

        IWebElement searchButton = driver.FindElement(By.xpath("//*[@id=\"app\"]/div[2]/div[3]/div[1]/div[2]/div[2]/div/div/div[2]/form/div/button"));
        public void clickSearchButton()
        {
            searchButton.Click();
        }

        IWebElement filterButton = driver.FindElement(By.xpath("/html/body/div[1]/div[2]/div[3]/div[1]/div[2]/div[3]/div/main/header/div/form/div[2]/div/div[1]/div/span/span[1]/span"));
        public void clickFilterButton()
        { 
            filterButton.Click(); 
        }

        IWebElement filterLocationOption = driver.FindeElement(By.Id("location"));
        public void filterLocation()
        {
            filterLocationOption.Click();
        }

        IWebElement locationField = driver.FindElement(By.xpath("//*[@id=\"ma-FormFiltersPopoverModal\"]/div/div/div[2]/div/div[2]/div/div/div/div[2]/div/div/div/div[1]/div/div/div/div/div/div/input"));
        public void fillingLocation()
        {
            locationField.Click();
            locationField.SendKeys("Barcelona");
        }

        IWebElement barcelonaOption = driver.FindElement(By.xpath(" //*[@id=\"ma-FormFiltersPopoverModal\"]/div/div/div[2]/div/div[2]/div/div/div/div[2]/div/div/div/div[1]/div/div/div/div/ul/li[1]/span/span[1]/span/em"));
        public void choosingAnOptionInTheDropdown()
        {
            barcelonaOption.Click();
        }

        IWebElement seeAds = driver.FindElement(By.Id("vendedor"));
        public void verAnuncios()
        {
            seeAds.Click();
        }

        IWebElement particularButton = driver.FindElement(By.Id("vendedor"));
        public void choosingParticularOptions()
        { 
            particularButton.Click(); 
        }

        IWebElement storesAmarillos = driver.FindElement(By.Id("storesArmarillos"));
        public void typeProduct()
        {
            storesAmarillos.Click();
        }

        IWebElement productLocation = driver.FindElement(By.xpath("//*[@id=\"app\"]/div[2]/div[3]/div[1]/div[4]/div/main/article/section/div/div[3]/address/span[2]").text());
        public void productLocationAssert()
        {
            productLocation.Contains("Esparreguera");
        }

        IWebElement messageButton = driver.FindElement(By.xpath("//*[@id=\"app\"]/div[2]/div[3]/div[1]/div[4]/div/main/article/section/aside/div[1]/div/div/button[1]"));
        public void clickOnTheMessageButton()
        {
            messageButton.Click();
        }

        IWebElement withEmailOption = driver.FindElement(By.xpath("//*[@id=\"modal-react-portal\"]/div[6]/div/div[2]/div/div/div[2]/button"));
        public void clickOnTheWithEmailOption()
        {
            withEmailOption.Click();
        }

        IWebElement messageNameField = driver.FindElement(By.Id("nombre"));
        IWebElement messageEmailField = driver.FindElement(By.Id("email"));
        IWebElement messageField = driver.FindElement(By.Id("message"));
        public void fillingMessageForm()
        {
            messageNameField.SendKeys("Pablo Ortiz");
            messageEmailField.SendKeys("pablo_ortiz_07@hotmail.com");
            messageField.SendKeys("Prueba automática de QA");
        }

    }
}
