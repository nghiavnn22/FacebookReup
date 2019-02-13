using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var fb = new FacebookClient("EAAbZBs0iZCgnYBANSzmxHsxiaKySaGZBqhr6zQhkZCCEZBIvLJqebaJQrxqS1OZAsxFnr6ifXuaQEITeu6bMQFTZC86Mj1Fe5ZC1LVaRgl3dtNOMToXsu1DQZBwb1FEpQ5U4giUv7CXG3MgHR4bjWZCbu4QpPYoZB5YWWx7bA0W2sdWlkGqBaYh4x1J0HJZAqsoZCyqfzj7SMxVGoXilZBZChoKB0Y7nm46B94WYmvZCZA6X9xqjAIgZDZD");
            fb.AppId = "1968895833375350";
            fb.AppSecret = "0MO_iuADl5IWkXEUvfrENWGwdYU";
            dynamic parameters = new ExpandoObject();
            parameters.source = new FacebookMediaObject { ContentType = "video/mp4", FileName = "video.mp4" }.SetValue(File.ReadAllBytes(@"c:\cho.mp4"));
            parameters.title = "video title";
           parameters.description = "video description";
            dynamic result = fb.Post("me/videos", parameters);
            Console.WriteLine(result);
        }
    }
}
