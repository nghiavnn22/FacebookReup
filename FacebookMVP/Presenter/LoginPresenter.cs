using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookMVP.Views;
using FacebookMVP.Models;
using FacebookMVP.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace FacebookMVP.Presenter
{
    class LoginPresenter
    {
        IMainLogin loginView;
        public LoginPresenter(IMainLogin view)
        {
            loginView = view;
            loadAccount();
        }
        public void checkLogin()
        {
            Account account = new Account();
            account.username = loginView.Username.ToString();
            account.password = loginView.Password.ToString();
            if (account.username=="nghiavnn22")
            {
                Console.WriteLine("dung tai khoan nghiavnn22");
            }
        }
        public void loginFacebook()
        {
            //Login
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://m.facebook.com/");
            IWebElement loginelement = driver.FindElement(By.Name("email"));
            loginelement.SendKeys(loginView.Username.ToString());
            IWebElement pass = driver.FindElement(By.Name("pass"));
            pass.SendKeys(loginView.Password.ToString());
            IWebElement loginsubmit = driver.FindElement(By.Name("login"));
            loginsubmit.Submit();
            //Get Cookie
            driver.Navigate().GoToUrl("https://m.facebook.com/");
            var cookies = driver.Manage().Cookies.AllCookies;
            List<Cookie> list = cookies.ToList();
            string strCookie = "";
            foreach (var cookie in list)
            {
                strCookie+=cookie.Name+"="+cookie.Value+";";
            }
            //get Name
            driver.Navigate().GoToUrl("https://m.facebook.com/settings/account/");
            IWebElement nameElement = driver.FindElement(By.Id("u_0_0"));
            string name = nameElement.FindElement(By.TagName("span")).Text;
            

        
            //Save information of facebook account
            using (var db = new FacebookAccountDB())
            {
                Account newAccount = new Account { username = loginView.Username.ToString(), password = loginView.Password.ToString(), cookie = strCookie,name=name};
                db.Accounts.Add(newAccount);
                db.SaveChanges();
            }
        }
        public void loadAccount()
        {
            using (var db = new FacebookAccountDB())
            {
                loginView.DataGridViewAccount = db.Accounts.ToList();
            }
        }
        public void getCookie()
        {

        }
        public void loginWithCookie(Account account)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://m.facebook.com/");
            string[] listCookie = account.cookie.ToString().Split(';');
            foreach (var cookie in listCookie)
            {
                string strCookie = cookie.Trim();
                int indexOf = strCookie.IndexOf("=");
                if (indexOf!=-1)
                {
                    string key = strCookie.Substring(0, indexOf).Trim();
                    string value = strCookie.Substring(indexOf + 1).Trim();
                    Cookie c = new Cookie(key, value);
                    driver.Manage().Cookies.AddCookie(c);
                }             
            }
            driver.Navigate().GoToUrl("https://m.facebook.com/");
        }
        

               
            
    }
}

