using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
 

namespace SeleniumTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //setCookie();
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://m.facebook.com/");
            IWebElement loginelement = driver.FindElement(By.Name("email"));
            loginelement.SendKeys("huunghiaphuyen@gmail.com");
            IWebElement pass = driver.FindElement(By.Name("pass"));
            pass.SendKeys("Nghianecu1");
            IWebElement loginsubmit = driver.FindElement(By.Name("login"));
            loginsubmit.Submit();
            var cookies = driver.Manage().Cookies.AllCookies;
            List<Cookie> list = cookies.ToList();
            driver.Navigate().GoToUrl("https://m.facebook.com/");

            ////xoa toan bo cookie
            //driver.Manage().Cookies.DeleteAllCookies();
            //driver.Navigate().GoToUrl("https://m.facebook.com/");
            //foreach (Cookie cookie in list)
            //{
            //    driver.Manage().Cookies.AddCookie(cookie);
            //}
            //driver.Navigate().GoToUrl("https://m.facebook.com/");
            foreach (var cookie in cookies)
            {
                Console.Write(cookie.Name + "=");
                Console.WriteLine(cookie.Value + ";");
                driver.Manage().Cookies.AddCookie(cookie);
            }
            //driver.Navigate().GoToUrl("https://m.facebook.com/");


        }
        public void setCookie()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://m.facebook.com/");
            Cookie ck2 = new Cookie("xs", "2%3A1ob_RlTRHLZxrg%3A2%3A1549406679%3A7945%3A6175");
            Cookie ck3 = new Cookie("c_user", "100006675676616");
            Cookie ck4 = new Cookie("datr", "1RFaXIYUDSaTqCpxKTpN6uLj");
            Cookie ck5 = new Cookie("sb", "1RFaXCxo6d2CUjHLQ0tbbkYu");
            Cookie ck6 = new Cookie("m_pixel_ratio", "1");
            Cookie ck7 = new Cookie("wd", "912x888");
            Cookie ck8 = new Cookie("pl", "n");
            Cookie ck1 = new Cookie("fr", "1yG1aSREJQ2k0aYOL.AWVSEiU7Vy4rcrA3QWrz0-Ouy94.BcWhHV.hO.AAA.0.0.BcWhHX.AWWfjNTI");
            driver.Manage().Cookies.AddCookie(ck1);
            driver.Manage().Cookies.AddCookie(ck2);
            driver.Manage().Cookies.AddCookie(ck3);
            driver.Manage().Cookies.AddCookie(ck4);
            driver.Manage().Cookies.AddCookie(ck5);
            driver.Manage().Cookies.AddCookie(ck6);
            driver.Manage().Cookies.AddCookie(ck7);
            driver.Manage().Cookies.AddCookie(ck8);
            //driver.Manage().Cookies.AddCookie();
            driver.Navigate().GoToUrl("https://m.facebook.com/");

        }

    }
}
