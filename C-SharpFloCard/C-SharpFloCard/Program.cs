using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpFloCard
{
    internal class Program
    {
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()        /* Redirecting to the Google page and navigating to Flocard app through google*/
        {
            // Navigating to the Flocard app through google.com
            driver.Navigate().GoToUrl("https://flocard.app/");
            Console.WriteLine("Website Initialized!");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Contact()
        {
            IWebElement contact = driver.FindElement(By.XPath("//*[@id=\'navBar\']/div/ul/li[4]/a"));       // Navigating to Contact section
            contact.Click();

            // Sending inputs in the contact sections wherever needed
            IWebElement fname = driver.FindElement(By.XPath("//*[@id=\'firstName\']"));         // Input in First Name
            fname.SendKeys("Abhinava");
            IWebElement lname = driver.FindElement(By.XPath("//*[@id=\'lastName\']"));          // Input in Last Name
            lname.SendKeys("Karmakar");
            IWebElement email = driver.FindElement(By.XPath("//*[@id=\"emailAddress\"]"));      // Input in Email Address
            email.SendKeys("Abhinava.Karmakar@366Pi.com");
            IWebElement message = driver.FindElement(By.XPath("//*[@id=\'message\']"));         // Input in Message section
            message.SendKeys("Working as an intern in 366 Pi for 16 weeks. The mentors here are amazing and I can grasp everything they teach me although it takes a some time to get it");

            Console.WriteLine("Website Executed");      /* This output will be shown if the testing is successful*/
        }

        [Test]
        public void ImpactSDG()
        {
            IWebElement impact = driver.FindElement(By.XPath("//*[@id=\'navBar\']/div/ul/li[1]/a"));    /* Navigating to Impact SDG section*/
            impact.Click();

            Console.WriteLine("Website Executed!");     /* This output will be shown if the testing is successful*/
        }

        [Test]
        public void IntegratedSolutions1()
        {
            IWebElement integrated1 = driver.FindElement(By.XPath("//*[@id=\'navBar\']/div/ul/li[2]/a"));
            integrated1.Click();        /* Navigating to Integrated Solutions section */
            IWebElement enterprise = driver.FindElement(By.XPath("//*[@id=\'content\']/div[1]/section/div/div/div/div[2]/div[1]/a/div/div[2]/h3"));
            enterprise.Click();         /* Navigating inside Integrated Solutions and then entering the Enterprise section */

            Console.WriteLine("Website Executed!");     /* This output will be shown if the testing is successful*/
        }

        [Test]
        public void IntegratedSolutions2()
        {
            IWebElement integrated2 = driver.FindElement(By.XPath("//*[@id=\'navBar\']/div/ul/li[2]/a"));
            integrated2.Click();        /* Navigating to Integrated Solutions section */
            IWebElement planters = driver.FindElement(By.XPath("//*[@id=\'content\']/div[1]/section/div/div/div/div[2]/div[2]/a/div/div[2]/h3"));
            planters.Click();           /* Navigating inside Integrated Solutions and then entering the Planters section */

            Console.WriteLine("Website Executed!");     /* This output will be shown if the testing is successful */
        }

        [Test]
        public void AboutUs()
        {
            IWebElement aboutus = driver.FindElement(By.XPath("//*[@id=\'navBar\']/div/ul/li[5]/a"));
            aboutus.Click();            /* Navigating to About Us section */

            Console.WriteLine("Website Executed!");     /* This output will be shown if the testing is successful*/
        }

        [Test]
        public void Knowledge1()
        {
            IWebElement knowledge1 = driver.FindElement(By.XPath("//*[@id=\'navBar\']/div/ul/li[3]/a"));
            knowledge1.Click();          /* Navigating to Knowledge section */
            IWebElement climate = driver.FindElement(By.XPath("//*[@id=\'content\']/div[1]/section/div/div/div/div/div[1]/a/div/img"));
            climate.Click();             /* Navigating to climate page */

            Console.WriteLine("Website Executed!");     /* This output will be shown if the testing is successful */
        }

        [Test]
        public void Knowledge2()
        {
            IWebElement knowledge2 = driver.FindElement(By.XPath("//*[@id=\'navBar\']/div/ul/li[3]/a"));
            knowledge2.Click();          /* Navigating to Knowledge section */
            IWebElement climategame = driver.FindElement(By.XPath("//*[@id=\'content\']/div[1]/section/div/div/div/div/div[2]/a/div/img"));
            climategame.Click();         /* Navigating to Climate Game section */

            Console.WriteLine("Website Executed!");     /* This output will be shown if the testing is successful */
        }

        [Test]
        public void GetStartedGoogle()
        {
            IWebElement getstarted1 = driver.FindElement(By.XPath("//*[@id=\'logoAndNav\']/nav/div/div[1]/a"));
            getstarted1.Click();         /* Navigating to the Get Started section in FloCard App */
            IWebElement google = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[1]/span"));
            google.Click();             /* Choosing the SignIn with google option */
            IWebElement logingoogle = driver.FindElement(By.XPath("//*[@id=\'identifierId\']"));
            logingoogle.SendKeys("abhinavakarmakar470@gmail.com");
            IWebElement next1 = driver.FindElement(By.XPath("//*[@id=\'identifierNext\']/div/button/span"));
            next1.Click();
            IWebElement passwordlog = driver.FindElement(By.XPath("//*[@id=\'password\']/div[1]/div/div[1]/input"));
            passwordlog.SendKeys("tosengeldaw");
            IWebElement next2 = driver.FindElement(By.XPath("//*[@id=\'passwordNext\']/div/button/span"));
            next2.Click();


            Console.WriteLine("Website Executed!");
        }

        [Test]
        public void GetStartedLinkedIn1()
        {
            IWebElement getstarted2 = driver.FindElement(By.XPath("//*[@id=\'logoAndNav\']/nav/div/div[1]/a"));
            getstarted2.Click();         /* Navigating to the Get Started section in FloCard App */
            IWebElement linkedin = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linkedin.Click();
            IWebElement username = driver.FindElement(By.XPath("//*[@id=\'username\']"));
            username.SendKeys("abhinavakarmakar470@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            password.SendKeys("tosengeldaw");
            IWebElement signin = driver.FindElement(By.XPath("//*[@id=\'app__container\']/main/div[2]/form/div[3]/button"));
            signin.Click();

            IWebElement exchange = driver.FindElement(By.XPath("//*[@id=\'exchangemenu\']/a/span"));
            exchange.Click();
            IWebElement exchangeC = driver.FindElement(By.XPath("//*[@id=\'lnkExchangeCodes\']/span[2]"));
            exchangeC.Click();
        }

        [Test]
        public void GetStartedLinkedIn2()
        {
            IWebElement getstarted2 = driver.FindElement(By.XPath("//*[@id=\'logoAndNav\']/nav/div/div[1]/a"));
            getstarted2.Click();         /* Navigating to the Get Started section in FloCard App */
            IWebElement linkedin = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linkedin.Click();
            IWebElement username = driver.FindElement(By.XPath("//*[@id=\'username\']"));
            username.SendKeys("abhinavakarmakar470@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            password.SendKeys("tosengeldaw");
            IWebElement signin = driver.FindElement(By.XPath("//*[@id=\'app__container\']/main/div[2]/form/div[3]/button"));
            signin.Click();

            IWebElement exchange = driver.FindElement(By.XPath("//*[@id=\'exchangemenu\']/a/span"));
            exchange.Click();
            IWebElement reqexchange = driver.FindElement(By.XPath("//*[@id=\'lnkExchangeReceive\']/span[2]"));
            reqexchange.Click();
        }

        [Test]
        public void GetStartedLinkedIn3()
        {
            IWebElement getstarted2 = driver.FindElement(By.XPath("//*[@id=\'logoAndNav\']/nav/div/div[1]/a"));
            getstarted2.Click();         /* Navigating to the Get Started section in FloCard App */
            IWebElement linkedin = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linkedin.Click();
            IWebElement username = driver.FindElement(By.XPath("//*[@id=\'username\']"));
            username.SendKeys("abhinavakarmakar470@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            password.SendKeys("tosengeldaw");
            IWebElement signin = driver.FindElement(By.XPath("//*[@id=\'app__container\']/main/div[2]/form/div[3]/button"));
            signin.Click();
            
            IWebElement contacts = driver.FindElement(By.XPath("//*[@id=\'lnkContacts\']/span"));
            contacts.Click();
        }

        [Test]
        public void GetStartedLinkedIn4()
        {
            IWebElement getstarted2 = driver.FindElement(By.XPath("//*[@id=\'logoAndNav\']/nav/div/div[1]/a"));
            getstarted2.Click();         /* Navigating to the Get Started section in FloCard App */
            IWebElement linkedin = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linkedin.Click();
            IWebElement username = driver.FindElement(By.XPath("//*[@id=\'username\']"));
            username.SendKeys("abhinavakarmakar470@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            password.SendKeys("tosengeldaw");
            IWebElement signin = driver.FindElement(By.XPath("//*[@id=\'app__container\']/main/div[2]/form/div[3]/button"));
            signin.Click();

            IWebElement flocardID = driver.FindElement(By.XPath("//*[@id=\'lnkAddress\']/span"));
            flocardID.Click();

        }

        [Test]
        public void GetStartedLinkedIn5()
        {
            IWebElement getstarted2 = driver.FindElement(By.XPath("//*[@id=\'logoAndNav\']/nav/div/div[1]/a"));
            getstarted2.Click();         /* Navigating to the Get Started section in FloCard App */
            IWebElement linkedin = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linkedin.Click();
            IWebElement username = driver.FindElement(By.XPath("//*[@id=\'username\']"));
            username.SendKeys("abhinavakarmakar470@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            password.SendKeys("tosengeldaw");
            IWebElement signin = driver.FindElement(By.XPath("//*[@id=\'app__container\']/main/div[2]/form/div[3]/button"));
            signin.Click();

            IWebElement planters = driver.FindElement(By.XPath("//*[@id=\'lnkPlanter\']/span"));
            planters.Click();

        }

        [Test]
        public void GetStartedLinkedIn6()
        {
            IWebElement getstarted2 = driver.FindElement(By.XPath("//*[@id=\'logoAndNav\']/nav/div/div[1]/a"));
            getstarted2.Click();         /* Navigating to the Get Started section in FloCard App */
            IWebElement linkedin = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linkedin.Click();
            IWebElement username = driver.FindElement(By.XPath("//*[@id=\'username\']"));
            username.SendKeys("abhinavakarmakar470@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            password.SendKeys("tosengeldaw");
            IWebElement signin = driver.FindElement(By.XPath("//*[@id=\'app__container\']/main/div[2]/form/div[3]/button"));
            signin.Click();

            IWebElement faq = driver.FindElement(By.XPath("//*[@id=\'lnkFAQ\']/span"));
            faq.Click();       
        }

        [Test]
        public void GetStartedLinkedIn7()
        {
            IWebElement getstarted2 = driver.FindElement(By.XPath("//*[@id=\'logoAndNav\']/nav/div/div[1]/a"));
            getstarted2.Click();         /* Navigating to the Get Started section in FloCard App */
            IWebElement linkedin = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linkedin.Click();
            IWebElement username = driver.FindElement(By.XPath("//*[@id=\'username\']"));
            username.SendKeys("abhinavakarmakar470@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            password.SendKeys("tosengeldaw");
            IWebElement signin = driver.FindElement(By.XPath("//*[@id=\'app__container\']/main/div[2]/form/div[3]/button"));
            signin.Click();

            IWebElement flocardpolicies = driver.FindElement(By.XPath("//*[@id=\'lnkPolicies\']/span"));
            flocardpolicies.Click();

        }

        [Test]
        public void GetStartedLinkedIn8()
        {
            IWebElement getstarted2 = driver.FindElement(By.XPath("//*[@id=\'logoAndNav\']/nav/div/div[1]/a"));
            getstarted2.Click();         /* Navigating to the Get Started section in FloCard App */
            IWebElement linkedin = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linkedin.Click();
            IWebElement username = driver.FindElement(By.XPath("//*[@id=\'username\']"));
            username.SendKeys("abhinavakarmakar470@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            password.SendKeys("tosengeldaw");
            IWebElement signin = driver.FindElement(By.XPath("//*[@id=\'app__container\']/main/div[2]/form/div[3]/button"));
            signin.Click();

            IWebElement support = driver.FindElement(By.XPath("//*[@id=\'lnkSupport\']/span"));
            support.Click();

        }

        [Test]
        public void GetStartedLinkedIn9()
        {
            IWebElement getstarted2 = driver.FindElement(By.XPath("//*[@id=\'logoAndNav\']/nav/div/div[1]/a"));
            getstarted2.Click();         /* Navigating to the Get Started section in FloCard App */
            IWebElement linkedin = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linkedin.Click();
            IWebElement username = driver.FindElement(By.XPath("//*[@id=\'username\']"));
            username.SendKeys("abhinavakarmakar470@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            password.SendKeys("tosengeldaw");
            IWebElement signin = driver.FindElement(By.XPath("//*[@id=\'app__container\']/main/div[2]/form/div[3]/button"));
            signin.Click();

            IWebElement mycard = driver.FindElement(By.XPath("//*[@id=\'lnkMycards\']/span"));
            mycard.Click();
            IWebElement addcard = driver.FindElement(By.XPath("//*[@id=\'new_card_id\']/div/div[1]/a/img"));
            addcard.Click();

            IWebElement fullname = driver.FindElement(By.XPath("//*[@id=\'txtName\']"));
            fullname.SendKeys("");
            IWebElement position = driver.FindElement(By.XPath("//*[@id=\'txtHeadline\']"));
            position.SendKeys("Intern");
            IWebElement email = driver.FindElement(By.XPath("//*[@id=\'txtEmail\']"));
            email.SendKeys("");
            IWebElement phone = driver.FindElement(By.XPath("//*[@id=\'txtPhone\']"));
            phone.SendKeys("9862878104");
            IWebElement website = driver.FindElement(By.XPath("//*[@id=\'txtWebsite\']"));
            website.SendKeys("Google Chrome");
            IWebElement fb = driver.FindElement(By.XPath("//*[@id=\'txtFacebook\']"));
            fb.SendKeys("AkBloodZ");
            IWebElement insta = driver.FindElement(By.XPath("//*[@id=\'txtInstagram\']"));
            insta.SendKeys("ak_bloodz");
            IWebElement linkedinacc = driver.FindElement(By.XPath("//*[@id=\'txtLinkedin\']"));
            linkedinacc.SendKeys("abhinava-karmakar-a5243623a");
            IWebElement cardtype = driver.FindElement(By.XPath("//*[@id=\'content\']/div[1]/section/div/div/div[2]/div/div/form/div[10]/div/div/div[2]/div[2]/div/label"));
            cardtype.Click();
            IWebElement creation = driver.FindElement(By.XPath("//*[@id=\'content\']/div[1]/section/div/div/div[2]/div/div/form/div[12]/input"));
            creation.Click();
        
        }

        [Test]
        public void GetStartedLinkedIn10()
        {
            IWebElement getstarted2 = driver.FindElement(By.XPath("//*[@id=\'logoAndNav\']/nav/div/div[1]/a"));
            getstarted2.Click();         /* Navigating to the Get Started section in FloCard App */
            IWebElement linkedin = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linkedin.Click();
            IWebElement username = driver.FindElement(By.XPath("//*[@id=\'username\']"));
            username.SendKeys("abhinavakarmakar470@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            password.SendKeys("tosengeldaw");
            IWebElement signin = driver.FindElement(By.XPath("//*[@id=\'app__container\']/main/div[2]/form/div[3]/button"));
            signin.Click();

            // updating the flocard
            IWebElement dots = driver.FindElement(By.XPath("//*[@id=\'editIntro\']"));
            dots.Click();
            IWebElement edit = driver.FindElement(By.XPath("//*[@id=\'connectionsDropdown1\']/div/a"));
            edit.Click();
            IWebElement EditName = driver.FindElement(By.XPath("//*[@id=\'txtName\']"));
            EditName.SendKeys("Ak");
            IWebElement EditPos = driver.FindElement(By.XPath("//*[@id=\'txtHeadline\']"));
            EditPos.SendKeys("Internship");
            IWebElement EditPhone = driver.FindElement(By.XPath("//*[@id=\'txtPhone\']"));
            EditPhone.SendKeys("7489520524");
            IWebElement EditWeb = driver.FindElement(By.XPath("//*[@id=\'txtWebsite\']"));
            EditWeb.SendKeys("www.ak123.com");
            IWebElement EditFb = driver.FindElement(By.XPath("//*[@id=\'txtFacebook\']"));
            EditFb.SendKeys("www.fb.com");
            IWebElement EditInsta = driver.FindElement(By.XPath("//*[@id=\'txtInstagram\']"));
            EditInsta.SendKeys("www.insta.com");
            IWebElement EditTwitter = driver.FindElement(By.XPath("//*[@id=\'txtTwitter\']"));
            EditTwitter.SendKeys("www.tweet.com");
            IWebElement Editlinkedin = driver.FindElement(By.XPath("//*[@id=\'txtLinkedin\']"));
            Editlinkedin.SendKeys("www.link.com");
            IWebElement EditTag = driver.FindElement(By.XPath("//*[@id=\'content\']/div[1]/section/div/div/div/div/form/div[12]/div/tags/span"));
            EditTag.SendKeys("homeoffice");
            IWebElement updateCard = driver.FindElement(By.XPath("//*[@id=\'content\']/div[1]/section/div/div/div/div/form/div[13]/div/input[2]"));
            EditTag.Click();


        }

        [TearDown]
        public void Cleanup()
        {
            // driver.Close();
            Console.WriteLine("Website Closed!");
        }
    }
}
