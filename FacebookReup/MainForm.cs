using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FacebookReup.DAL;
using Newtonsoft.Json;
using FacebookReup.Model;
using System.IO;
using System.Threading;

namespace FacebookReup
{
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            
            InitializeComponent();
           // getAcessToken();
            // getFancount("523454094512122", "EAAbZBs0iZCgnYBABwVKWCt8YlJ0m3cpvtnRPOrkkN2Au8K9UJXMRNJgi2jmrvLGsADmvBMs1ySVEwaIFjfG2Xmo1formnwTOXady1lyxCqAvmGCUuRrNdXEBLbRHUtyZAGCmVSiZCOvHxPvjB39nKBrK4FglsdsqpBnNFPDuKwZDZD");
            dataGridViewPage.DataSource = getListFanpge("1968895833375350", "0MO_iuADl5IWkXEUvfrENWGwdYU", "EAAbZBs0iZCgnYBAGIScC7ZCzOPekhGgZBSq3Jby2VSZASY47SDMlmEuZCf9ZAVZCzAZCIZCOUOa9ts9QCxm3W8ZCpH9CJJTj170TPn8Id6QvPom5H9CxLI5OLyAqZAnu0c1hOeFjPH3q0wBNxUZAHaafw3BjzitC5z5zqIkFqq66AenhlegZDZD");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:mm dd-MM-yyyy";
            // loadDataGrid();

        }
        public void loadDataGrid()
        {
           // string idApp = txtIDAPP.Text.ToString();
          //  string idScret = txtScrectApp.Text.ToString();
           // string accesstoken = txtAccessToken.Text.ToString();
       //     dataGridViewPage.DataSource = getListFanpge("1968895833375350", "0MO_iuADl5IWkXEUvfrENWGwdYU", "EAAbZBs0iZCgnYBABwVKWCt8YlJ0m3cpvtnRPOrkkN2Au8K9UJXMRNJgi2jmrvLGsADmvBMs1ySVEwaIFjfG2Xmo1formnwTOXady1lyxCqAvmGCUuRrNdXEBLbRHUtyZAGCmVSiZCOvHxPvjB39nKBrK4FglsdsqpBnNFPDuKwZDZD");
        }
        public string getFanCount(string idfanpage,string idApp,string idScret, string accessToken)
        {
            FacebookClient c = new FacebookClient(accessToken);
            c.AppId = idApp;
            c.AppSecret = idScret;
            string json = c.Get(idfanpage+"?fields=fan_count").ToString() ;
            
            return json;
        }
        public List<Fanpage> getListFanpge(string idApp, string idScret, string accessToken)
        {
            List<Fanpage> listPage = new List<Fanpage>();
            FacebookClient client = new FacebookClient(accessToken);
            client.AppId = idApp;
            client.AppSecret = idScret;
            String json = client.Get("me/accounts?field=id,nam  e,access_token").ToString();
            var root = JsonConvert.DeserializeObject<RootObject>(json);
            foreach (var item in root.data)
            {
                dynamic stuff = JsonConvert.DeserializeObject(getFanCount(item.id, idApp, idScret, accessToken));
                string fancount1 = stuff.fan_count;
                
                
                getFanCount(item.id, idApp, idScret, accessToken);
                listPage.Add(new Fanpage
                {
                    id = item.id,
                    name = item.name,
                    accessToken = item.access_token,
                    fancount = fancount1.ToString()
                    

            }
                   );
            }
            return listPage;

        }
        public void getAcessToken()
        {
            var fb = new FacebookClient();
            dynamic result = fb.Get("oauth/access_token", new
            {
                client_id = "1968895833375350",
                client_secret = "fc6a11e0d7d24dca7eb86451ef73b031",
                grant_type = "client_credentials"
            });
            fb.AccessToken = result.access_token;
            MessageBox.Show(result.access_token);
        }
        
        private void btnReup_Click(object sender, EventArgs e)
        {
            List<Fanpage> listPage = getListFanpge("1968895833375350", "0MO_iuADl5IWkXEUvfrENWGwdYU", "EAAbZBs0iZCgnYBAGIScC7ZCzOPekhGgZBSq3Jby2VSZASY47SDMlmEuZCf9ZAVZCzAZCIZCOUOa9ts9QCxm3W8ZCpH9CJJTj170TPn8Id6QvPom5H9CxLI5OLyAqZAnu0c1hOeFjPH3q0wBNxUZAHaafw3BjzitC5z5zqIkFqq66AenhlegZDZD");
            string filePath = btnFile.Text.ToString();
            string message = richtxtMessage.Text.ToString();
            DateTime datetime = dateTimePicker1.Value;
            string time = ((DateTimeOffset)datetime).ToUnixTimeSeconds().ToString();
            
            if (labelTypeFile.Text.ToString()==".jpg"|| labelTypeFile.Text.ToString() == ".img")
            {
                Parallel.ForEach(listPage,(page)=>
                {
                    upImageToFanpage(page, filePath, message, time);
                });
                // post image tuan` tu
                //foreach (var page in listPage)
                //{
                //     upImageToFanpage(page, filePath, message,time);
                //}
                Console.WriteLine("DA UPLOAD HINH ANH CHO TAT CA PAGE XONG");
                labelThongBao.Text = "Đã post xong "+filePath+ " vào lúc "+ datetime.Hour+" Giờ, "+datetime.Minute +" Phút, Ngày"+ datetime.Day+" Tháng: "+datetime.Month;
            }
            else
            {
                Console.WriteLine("dang post");
                Parallel.ForEach(listPage, (page) =>
                {
                    upVideoToFanpage(page, filePath, message, time);
                });
                // post video tuan tu
                //foreach (var page in listPage)
                //{                 
                //    upVideoToFanpage(page, filePath, message, time);
                //}
                Console.WriteLine("DA UPLOAD VIDEO CHO TAT CA PAGE XONG");
            }





        }

        private void upVideoToFanpage(Fanpage page, string filePath, string message)
        {
            throw new NotImplementedException();
        }

        public void upVideoToFanpage(Fanpage fanpage, string filePath, string message,string time)
        {
            {
                
                
                var mediaObject = new FacebookMediaObject
                {
                    FileName = System.IO.Path.GetFileName(filePath),
                    ContentType = "video/mp4"
                };
                mediaObject.SetValue(System.IO.File.ReadAllBytes(filePath));
                try
                {
                    var fb = new FacebookClient(fanpage.accessToken);
                   
                    Console.WriteLine(fanpage.accessToken);
                    Console.WriteLine(mediaObject.ToString());
                    var result = (IDictionary<string, object>)fb.Post(fanpage.id + "/videos", new Dictionary<string, object>
                                   {
                                         { "source", mediaObject },
                                          {"published","false" },
                                        {"scheduled_publish_time",time},
                                        { "description",message}

                                   });
                    var postId = (string)result["id"];

                    Console.WriteLine("Post Id: {0}", postId);
                    Console.WriteLine(fanpage.name + " da post xong tu file " + filePath.ToString());

                    // Note: This json result is not the orginal json string as returned by Facebook.
                    Console.WriteLine("Ket qua Json: {0}", result.ToString());
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
       // 523454094512122/?fields=fan_count
        

        public void upImageToFanpage(Fanpage fanpage,string filePath,string message, string time)
        {
            {
                var mediaObject = new FacebookMediaObject
                {
                    FileName = System.IO.Path.GetFileName(filePath),
                    ContentType = "image/jpg"

                };
                mediaObject.SetValue(System.IO.File.ReadAllBytes(filePath));
                try
                {
                    var fb = new FacebookClient(fanpage.accessToken);


                    var result = (IDictionary<string, object>)fb.Post(fanpage.id + "/photos", new Dictionary<string, object>
                                   {
                                      { "source", mediaObject },
                                        {"published","false" },
                                        {"scheduled_publish_time",time},
                                       { "message",message}
                                       
                                   });

                    var postId = (string)result["id"];

                    Console.WriteLine("Post Id: {0}", postId);
                    Console.WriteLine(fanpage.name +"da post xong"+filePath.ToString());

                    // Note: This json result is not the orginal json string as returned by Facebook.
                    Console.WriteLine("Json: {0}", result.ToString());

                   
                }
                catch (Exception)
                {
                    Application.Exit();
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    //throw;
                }
            }

        }
        public void reupYoutubeOnPage(Fanpage fanpage, string link)
        {

        }
        public void downloadLinkYoutube(string link)
        {

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog2 = new OpenFileDialog();
            if (openfileDialog2.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                string filename = openfileDialog2.FileName;
                btnFile.Text = filename;
                labelTypeFile.Text = Path.GetExtension(filename);
                //pictureBox1.Image = Image.FromFile(filename);
            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
