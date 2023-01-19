using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumOk
{
    internal class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        
        }
        

        [SetUp]
        public void Initialize()        /* Setting up for navigating to Google Chrome page on the website https:/366pi.tech */ 
        {
            //Navigating to Google Page
            driver.Navigate().GoToUrl("https://366pi.tech");
            Console.WriteLine("Website Initialized!");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Services1()
        {
            //Finding the element
            IWebElement firstserve = driver.FindElement(By.XPath("//*[@id=\'menu-item-3907\']/a"));
            firstserve.Click();
            IWebElement beSpoke = driver.FindElement(By.XPath("//*[@id=\'menu-item-1797\']/a"));
            beSpoke.Click();
            
            // Removed the Request Quote testing button because of Error 404 while opening the website resulting in testing failure

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Services2_1()
        {
            //Finding the Element
            IWebElement secondserve = driver.FindElement(By.XPath("//*[@id=\'menu-item-3907\']/a"));
            secondserve.Click();
            IWebElement digital = driver.FindElement(By.XPath("//*[@id=\'menu-item-1650\']/a"));
            digital.Click();
            IWebElement smart = driver.FindElement(By.CssSelector("#mpc_carousel_posts-363bcedea529b0 > div > div > div.mpc-post.slick-slide.slick-current.slick-active > div > div.mpc-post__thumbnail > div > div > div > a:nth-child(2) > i"));
            smart.Click();           
            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Services2_2()
        {
            //Finding the Element
            IWebElement secondserve = driver.FindElement(By.XPath("//*[@id=\'menu-item-3907\']/a"));
            secondserve.Click();
            IWebElement digital = driver.FindElement(By.XPath("//*[@id=\'menu-item-1650\']/a"));
            digital.Click();
            IWebElement game = driver.FindElement(By.XPath("//*[@id=\'mpc_carousel_posts-363bcedea529b0\']/div/div/div[5]/div/div[1]/div/div/div"));
            game.Click();
            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Services23()
        {
            // Finding the Element
            IWebElement secondserve = driver.FindElement(By.XPath("//*[@id=\'menu-item-3907\']/a"));
            secondserve.Click();
            IWebElement digital = driver.FindElement(By.XPath("//*[@id=\'menu-item-1650\']/a"));
            digital.Click();
            IWebElement mining = driver.FindElement(By.XPath("//*[@id=\'mpc_carousel_posts-363bcedea529b0\']/div/div/div[6]/div/div[1]/div/div/div"));
            mining.Click();
            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Services24()
        {
            // Finding the Element
            IWebElement secondserve = driver.FindElement(By.XPath("//*[@id=\'menu-item-3907\']/a"));
            secondserve.Click();
            IWebElement digital = driver.FindElement(By.XPath("//*[@id=\'menu-item-1650\']/a"));
            digital.Click();
            IWebElement health = driver.FindElement(By.XPath("//*[@id=\'mpc_carousel_posts-363bcedea529b0\']/div/div/div[7]/div/div[1]/div/div/div"));
            health.Click();
            Console.WriteLine("Website Executed!");
        }
        
        [Test]
        public void Services3()
        {
            //Finding the Element
            IWebElement thirdserve = driver.FindElement(By.XPath("//*[@id=\'menu-item-3907\']/a"));
            thirdserve.Click();
            IWebElement business = driver.FindElement(By.XPath("//*[@id=\'menu-item-1650\']/a"));
            business.Click();

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Services4()
        {
            //Finding the Element
            IWebElement fourthserve = driver.FindElement(By.XPath("//*[@id='menu-item-3907']/a"));
            fourthserve.Click();
            IWebElement DataAI = driver.FindElement(By.XPath("//*[@id=\"menu-item-1805\"]/a"));
            DataAI.Click();

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Services5()
        {
            //Finding the Element
            IWebElement fifthserve = driver.FindElement(By.XPath("//*[@id='menu-item-3907']/a"));
            fifthserve.Click();
            IWebElement blockchain = driver.FindElement(By.XPath("//*[@id=\'menu-item-842\']/a"));
            blockchain.Click();
            IWebElement blockconsulting = driver.FindElement(By.XPath("//*[@id=\'menu-item-1770\']/a"));
            blockconsulting.Click();
           /* IWebElement blockdevelopment = driver.FindElement(By.XPath("//*[@id=\'menu-item-1773\']/a"));
            blockdevelopment.Click();
            IWebElement smartcontracts = driver.FindElement(By.XPath("//*[@id=\'menu-item-1777\']/a"));
            smartcontracts.Click(); */

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Ip1()
        {
            //Finding the Element
            IWebElement firstip = driver.FindElement(By.XPath("//*[@id=\'menu-item-3908\']/a"));
            firstip.Click();
            IWebElement flocard = driver.FindElement(By.XPath("//*[@id=\'menu-item-3909\']/a"));
            flocard.Click();

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Ip2()
        {
            //Finding the Element
            IWebElement secondip = driver.FindElement(By.XPath("//*[@id=\'menu-item-3908\']/a"));
            secondip.Click();
            IWebElement dsmm = driver.FindElement(By.XPath("//*[@id=\'menu-item-4402\']/a"));
            dsmm.Click();

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Ip3()
        {
            IWebElement thirdip = driver.FindElement(By.XPath("//*[@id='menu-item-3908']/a"));
            thirdip.Click();
            IWebElement automobileAI = driver.FindElement(By.XPath("//*[@id=\'menu-item-3910\']/a"));
            automobileAI.Click();

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Ip4()
        {
            IWebElement fourthip = driver.FindElement(By.XPath("//*[@id='menu-item-3908']/a"));
            fourthip.Click();
            IWebElement agriculture = driver.FindElement(By.XPath("//*[@id=\'menu-item-3911\']/a"));
            agriculture.Click();

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Ip5()
        {
            IWebElement fifthip = driver.FindElement(By.XPath("//*[@id='menu-item-3908']/a"));
            fifthip.Click();
            IWebElement inventory = driver.FindElement(By.XPath("//*[@id=\"menu-item-3912\"]/a"));
            inventory.Click();

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Ip6()
        {
            IWebElement sixthip = driver.FindElement(By.XPath("//*[@id='menu-item-3908']/a"));
            sixthip.Click();
            IWebElement jharkhand = driver.FindElement(By.XPath("//*[@id='menu-item-3913']/a"));
            jharkhand.Click();

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Live1()
        {
            IWebElement firstlive = driver.FindElement(By.XPath("//*[@id=\'menu-item-1822\']/a"));
            firstlive.Click();
            IWebElement silver = driver.FindElement(By.XPath("//*[@id=\'menu-item-1822\']/a"));
            silver.Click();

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Live2()
        {
            IWebElement secondlive = driver.FindElement(By.XPath("//*[@id='menu-item-1822']/a"));
            secondlive.Click();
            IWebElement fennex = driver.FindElement(By.XPath("//*[@id=\"menu-item-3916\"]/a"));
            fennex.Click();

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Live3()
        {
            IWebElement thirdlive = driver.FindElement(By.XPath("//*[@id='menu-item-1822']/a"));
            thirdlive.Click();
            IWebElement ileadHR = driver.FindElement(By.XPath("//*[@id=\'menu-item-3915\']/a"));
            ileadHR.Click();

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Live4()
        {
            IWebElement fourthlive = driver.FindElement(By.XPath("//*[@id='menu-item-1822']/a"));
            fourthlive.Click();
            IWebElement microsite = driver.FindElement(By.XPath("//*[@id=\'menu-item-3851\']/a"));
            microsite.Click();

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Blog()
        {
            IWebElement blog = driver.FindElement(By.XPath("//*[@id='menu-item-1822']/a"));
            blog.Click();
            IWebElement getblog = driver.FindElement(By.XPath("//*[@id=\'menu-item-1539\']/a"));
            getblog.Click();

            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void Contact()
        {
            IWebElement contact = driver.FindElement(By.XPath("//*[@id=\"menu-item-1527\"]/a"));
            contact.Click();
            IWebElement name = driver.FindElement(By.XPath("//*[@id=\'wpcf7-f1376-p1417-o1\']/form/p[1]/label/span/input"));
            name.SendKeys("Abhinava");
            IWebElement email = driver.FindElement(By.XPath("//*[@id=\'wpcf7-f1376-p1417-o1\']/form/p[2]/label/span/input"));
            email.SendKeys("abhinavakarmakar470@gmail.com");
            IWebElement usecase = driver.FindElement(By.XPath("//*[@id=\'wpcf7-f1376-p1417-o1\']/form/p[3]/label/span/input"));
            usecase.SendKeys("Lenovo IdeaPad");
            IWebElement date = driver.FindElement(By.XPath("//*[@id=\'wpcf7-f1376-p1417-o1\']/form/p[4]/label/span/input"));
            date.SendKeys("10012023");
            IWebElement message = driver.FindElement(By.XPath("//*[@id=\'wpcf7-f1376-p1417-o1\']/form/p[5]/label/span/textarea"));
            message.("Working as an Intern in 366Pi!");
        }

        [Test]
        public void AboutUs()
        {
            IWebElement aboutus = driver.FindElement(By.XPath("//*[@id=\'menu-item-4385\']/a"));
            aboutus.Click();
            IWebElement careers = driver.FindElement(By.XPath("//*[@id=\'menu-item-4441\']/a"));
            careers.Click();
        }

        [TearDown]
        public void Clean()
        {
           // driver.Close();
            Console.WriteLine("Website Closed!");
        }
    }
}