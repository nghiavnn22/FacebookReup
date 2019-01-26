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
using System.Collections;
using FacebookReup.Model;

namespace FacebookReup
{
    public partial class Form1 : Form
    {
        List<Fanpage> listPage;
        public Form1()
        {
            InitializeComponent();
            
            //listPage = getListFanpge("1968895833375350", "0MO_iuADl5IWkXEUvfrENWGwdYU", "EAAbZBs0iZCgnYBAMpPK1EqYT8JW0RftRlMYCWIZCRZBG9ScOZBcffEkWebGcli48zNOII1TKVZB2pL9reiRIx6b27U2na9a6wMTPLVAPj9fCgHd4rPKqIrL1wFV8JKgx1z3rTBofNpqHUgUZCiFb1qnjrKf2LUwnlz8Tuhbg7Tyq8wgSehMNF0B5XQgHzKsErDa45lUXIbVAgejuWnVzwZCbZCYAnjoalazpNbbyTZCPZBVBQZDZD");
           // dataGridView1.DataSource = listPage.ToList();
            
           //postAllFanpge(listPage);
            //up load image to group
            //   UploadPictureToGroup("926680707374301", "EAAEHSNbqyKEBAHfqsAZAe252wOcHs1xNjBqhuozYIh8ZCwqvSsK0K3PkeztJk1jfzeZCX6Cll20XEcveCl1pRhrZBZCpX7rPaTiZCfTyW6EwSRqXx2y14FSlfWjyiCK8K83OOVAJZC6FSlhMBGSgtr1OEh1IKhO2O2nEaRwvR2TscvyG9D8FDBZBGwZAdbnF9OUsZD", "C:/a.jpg");
            //  UploadVideoFromUrl("578337095953266", "EAAEHSNbqyKEBAAZCEANZAZAXMKWB4f9ndyeGV8N1iDETPoBpDrC7Wq4877A3XWFK9YvwsvAex4sFxomHSR9r4Kk9IrfaNE8dw7bsSGKan2mo1gqIcXJLpkNJbWu4dNtnuc6Eq1pjyqkKZC3B1Ic9SbHjyqVB9ZBXlvMDZAZAYZBCnT5zuymNSZAFZB", "https://sample-videos.com/video123/mp4/720/big_buck_bunny_720p_1mb.mp4");
            //upload video to fanpage va image
            //UploadVideoToWall("578337095953266", "EAAEHSNbqyKEBAAZCEANZAZAXMKWB4f9ndyeGV8N1iDETPoBpDrC7Wq4877A3XWFK9YvwsvAex4sFxomHSR9r4Kk9IrfaNE8dw7bsSGKan2mo1gqIcXJLpkNJbWu4dNtnuc6Eq1pjyqkKZC3B1Ic9SbHjyqVB9ZBXlvMDZAZAYZBCnT5zuymNSZAFZB", "C:/a.mp4");
            //UploadPictureToWall("578337095953266", "EAAbZBs0iZCgnYBALDKeIp6VKfLGHZCvYgqihyUq5jLqsbfxyZAG7yZBIpifARYNcFqX1UZCOIIZCSoTZCL5XlBbZC77mQFiQaDEdE5vEuyDzvYbah6U1qaBXP8ZBcY1wR4VC7UdXoPirhv2JPpqTuMTk8fDG82dJp35JKSm0xnuyz9drWzsELhhOsFrgXhzZBGRZAYajZA0iNdeqABgZDZD", "C:/a.jpg");
           // richTextBox1.Text= postFacebook("EAAEHSNbqyKEBAHfrJ3HeVvaKrJMGwo4gTZBKDSVXZCc9FGJkwCezdAHZAQMJ8fmfnLNQath40BuEpXYFm6NXUJbXgEF3Axv77DYpiicxMBM1YXiMSfRYEGJIfdvkFVEKqLwqVVA1zLMcGlZCB4E1jX65ZCYK9I0QZD");
        }
        public List<Fanpage> getListFanpge(string idApp,string idScret,string accessToken)
        {
            listPage = new List<Fanpage>();
            FacebookClient client = new FacebookClient(accessToken);
            client.AppId = idApp;
            client.AppSecret = idScret;
            String json = client.Get("me/accounts?field=id,name,access_token").ToString();
            var root = JsonConvert.DeserializeObject<RootObject>(json);
            foreach (var item in root.data)
            {
                listPage.Add(new Fanpage
                            {
                            id = item.id,
                            name = item.name,
                            accessToken = item.access_token
                            }
                   );
            }
            return listPage;

        }
        public void postAllFanpge(List<Fanpage> listPage)
        {
            foreach (var fanpage in listPage)
            {
               // UploadPictureToWall(fanpage.id, fanpage.accessToken, "C:/a.jpg");
                UploadVideoFromUrl(fanpage.id,fanpage.accessToken, "https://sample-videos.com/video123/mp4/720/big_buck_bunny_720p_1mb.mp4");
            }
        }


        public string postFacebook(string CurrentAccessToken)
        {

            FacebookClient client = new FacebookClient(CurrentAccessToken);
            client.AppId = "1968895833375350";
            client.AppSecret = "0MO_iuADl5IWkXEUvfrENWGwdYU";
            
            Dictionary<string, object> para = new Dictionary<string, object>();
            para["message"] = "Test message";

            
            String json = client.Get("me/accounts?fields=id,name,access_token").ToString();
            var root = JsonConvert.DeserializeObject<RootObject>(json);
            dataGridView1.DataSource = root.data.ToList();
            
            foreach (var item in root.data)
            {
                Fanpage fanpage = new Fanpage();
                fanpage.id = item.id.ToString();
                fanpage.name = item.name.ToString();
                fanpage.accessToken = item.access_token.ToString();

                listPage.Add(fanpage);

                
                txtID.Text += item.id.ToString();
                txtPass.Text += item.name.ToString();
               
            }
     
            return client.Get("me/accounts?fields=id,name,access_token").ToString();
            

           

        }
        public void upDataFanpgeToDataBase(string CurrentAccessToken)
        {
            
            FacebookClient client = new FacebookClient(CurrentAccessToken);
            client.AppId = "289484401461409";
            client.AppSecret = "eDuVD2C1Iq2bbhc9sYiQBvsMSr4";


            Dictionary<string, object> para = new Dictionary<string, object>();
            para["message"] = "Test message";


            String json = client.Get("me/accounts?fields=id,name,access_token").ToString();
            var root = JsonConvert.DeserializeObject<RootObject>(json);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = root.data.ToList();
        }
        // upload video to fanpage
        public static string UploadVideoToWall(string id, string accessToken, string filePath)
        {
            var mediaObject = new FacebookMediaObject
            {
                FileName = System.IO.Path.GetFileName(filePath),
                ContentType = "image/mp4"

            };
            mediaObject.SetValue(System.IO.File.ReadAllBytes(filePath));
            try
            {
                var fb = new FacebookClient(accessToken);
                

                var result = (IDictionary<string, object>)fb.Post(id + "/videos", new Dictionary<string, object>
                                   {
                                       { "source", mediaObject },
                                       { "message","videos" }
                                   });

                var postId = (string)result["id"];

                Console.WriteLine("Post Id: {0}", postId);

                // Note: This json result is not the orginal json string as returned by Facebook.
                Console.WriteLine("Json: {0}", result.ToString());

                return postId;
            }
            catch (Exception)
            {

                throw;
            }
        }
        // upload image to fanpage
        public static string UploadPictureToWall(string id, string accessToken, string filePath)
        {
            var mediaObject = new FacebookMediaObject
            {

                FileName = System.IO.Path.GetFileName(filePath),
                ContentType = "image/jpeg"
                

            };
            mediaObject.SetValue(System.IO.File.ReadAllBytes(filePath));
            try
            {
                var fb = new FacebookClient(accessToken);

                var result = (IDictionary<string, object>)fb.Post(id + "/photos", new Dictionary<string, object>
                                   {
                                       { "source", mediaObject },
                                       { "message","photo" }
                                   });

                var postId = (string)result["id"];

                Console.WriteLine("Post Id: {0}", postId);

                // Note: This json result is not the orginal json string as returned by Facebook.
                Console.WriteLine("Json: {0}", result.ToString());

                return postId;
            }
            catch (Exception)
            {

                throw;
            }
        }

        // upload video from url
        public static string UploadVideoFromUrl(string id, string accessToken, string url)
        {
            
            try
            {
                var fb = new FacebookClient(accessToken);

                var result = (IDictionary<string, object>)fb.Post(id + "/videos", new Dictionary<string, object>
                                   {
                                       { "file_url", url },
                                       {"start_offset","10"},
                                       {"end_offset","20" },
                                       { "message","videos" }
                                   });

                var postId = (string)result["id"];

                Console.WriteLine("Post Id: {0}", postId);

                // Note: This json result is not the orginal json string as returned by Facebook.
                Console.WriteLine("Json: {0}", result.ToString());

                return postId;
            }
            catch (Exception)
            {

                throw;
            }
        }
        // upload image to group
        public static string UploadPictureToGroup(string id, string accessToken, string filePath)
        {
            var mediaObject = new FacebookMediaObject
            {

                FileName = System.IO.Path.GetFileName(filePath),
                ContentType = "image/jpeg"


            };
            mediaObject.SetValue(System.IO.File.ReadAllBytes(filePath));
            try
            {
                var fb = new FacebookClient(accessToken);

                var result = (IDictionary<string, object>)fb.Post(id + "/photos", new Dictionary<string, object>
                                   {
                                       { "source", mediaObject },
                                       { "message","photo" }
                                   });

                var postId = (string)result["id"];

                Console.WriteLine("Post Id: {0}", postId);

                // Note: This json result is not the orginal json string as returned by Facebook.
                Console.WriteLine("Json: {0}", result.ToString());

                return postId;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void postToFanPage(string idFanpage,string message)
        {
            //
            FacebookClient client = new FacebookClient("");
        }
        public void getAcessFanPage(string idFanpge)
        {

        }

        //public static string RefreshTokenAndPostToFacebook(string currentAccessToken)
        //{
        //    string newAccessToken = RefreshAccessToken(currentAccessToken);
        //    string pageAccessToken = GetPageAccessToken(newAccessToken);
        //    PostToFacebook(pageAccessToken);oad 
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
