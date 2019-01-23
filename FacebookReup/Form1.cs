using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.IO;
using Facebook;
using Newtonsoft.Json;
using FacebookReup.Model;
using System.Collections;

namespace FacebookReup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text= postFacebook();
        }
        public string postFacebook()
        {
            FacebookClient client = new FacebookClient("EAAEHSNbqyKEBAOwZAAA12bBiBDbe6Qo3ZCmOZARlcdeUoS3nz1ZANCvKWK8safPOBvtC5svtXTUw2VOVuMtvqodB9mPSa7LM0AWh49kEZBZCXXKp06gXXdlQx6isqaal8hHrYssuevnmiXRIeX0xtd1E8hVp9H2NET3gD1pGmCdcZCSYjF9chUWmjtHYAdXqnWdjcjTY54d7TZCARygvcZANIoB46aaaybn1UTnK24L80nQZDZD");
            client.AppId = "289484401461409";
            client.AppSecret = "eDuVD2C1Iq2bbhc9sYiQBvsMSr4";
            
            
            Dictionary<string, object> para = new Dictionary<string, object>();
            para["message"] = "Test message";

            
            String json = client.Get("me/accounts?fields=id,name,access_token").ToString();
            var root = JsonConvert.DeserializeObject<RootObject>(json);
            
            
            foreach (var item in root.data)
            {
                txtID.Text += item.id.ToString();
                txtPass.Text += item.name.ToString();
                

            }
            
            
            return client.Get("me/accounts?fields=id,name,access_token").ToString();
            

           

        }
       

        //public static string RefreshTokenAndPostToFacebook(string currentAccessToken)
        //{
        //    string newAccessToken = RefreshAccessToken(currentAccessToken);
        //    string pageAccessToken = GetPageAccessToken(newAccessToken);
        //    PostToFacebook(pageAccessToken);
        //    return newAccessToken; // replace current access token with this
        //}

        //public static string GetPageAccessToken(string userAccessToken)
        //{
        //    FacebookClient fbClient = new FacebookClient();
        //    fbClient.AppId = "app id";
        //    fbClient.AppSecret = "app secret";
        //    fbClient.AccessToken = userAccessToken;
        //    Dictionary<string, object> fbParams = new Dictionary<string, object>();
        //    JsonObject publishedResponse = fbClient.Get("/me/accounts", fbParams) as JsonObject;
        //    JArray data = JArray.Parse(publishedResponse["data"].ToString());

        //    foreach (var account in data)
        //    {
        //        if (account["name"].ToString().ToLower().Equals("your page name"))
        //        {
        //            return account["access_token"].ToString();
        //        }
        //    }

        //    return String.Empty;
        //}

        //public static string RefreshAccessToken(string currentAccessToken)
        //{
        //    FacebookClient fbClient = new FacebookClient();
        //    Dictionary<string, object> fbParams = new Dictionary<string, object>();
        //    fbParams["client_id"] = "app id";
        //    fbParams["grant_type"] = "fb_exchange_token";
        //    fbParams["client_secret"] = "app secret";
        //    fbParams["fb_exchange_token"] = currentAccessToken;
        //    JsonObject publishedResponse = fbClient.Get("/oauth/access_token", fbParams) as JsonObject;
        //    return publishedResponse["access_token"].ToString();
        //}

        //public static void PostToFacebook(string pageAccessToken)
        //{
        //    FacebookClient fbClient = new FacebookClient(pageAccessToken);
        //    fbClient.AppId = "app id";
        //    fbClient.AppSecret = "app secret";
        //    Dictionary<string, object> fbParams = new Dictionary<string, object>();
        //    fbParams["message"] = "Test message";
        //    var publishedResponse = fbClient.Post("/your_page_name/feed", fbParams);
        //}



        private void btnLogin_Click(object sender, EventArgs e)
        {
            CookieCollection cookies = new CookieCollection();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.facebook.com");
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(cookies);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            cookies = response.Cookies;


            string getUrl = "https://www.facebook.com/login/device-based/regular/login/?login_attempt=1&lwv=111";
            string postData = String.Format("email={0}&pass={1}","huunghiaphuyen@gmail.com","ngoisaodo1");
            HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(getUrl);
            getRequest.CookieContainer = new CookieContainer();
            getRequest.CookieContainer.Add(cookies);
            getRequest.Method = WebRequestMethods.Http.Post;
            getRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
            getRequest.AllowWriteStreamBuffering = true;
            getRequest.ProtocolVersion = HttpVersion.Version11;
            getRequest.ContentType = "application/x-www-form-urlencoded";
            byte[] byteArray = Encoding.ASCII.GetBytes(postData);
            getRequest.ContentLength = byteArray.Length;
            Stream newStream = getRequest.GetRequestStream();
            newStream.Write(byteArray,0,byteArray.Length);
            newStream.Close();

            HttpWebResponse getResponse = (HttpWebResponse)getRequest.GetResponse();
            using (StreamReader sr = new StreamReader(getResponse.GetResponseStream()))
            {
                string sourceCode = sr.ReadToEnd();
            }
            
        }
    }
}
