using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;

namespace FacebookReup.Acction
{
    class FanpageAction
    {


        public void loadDataGridFanpage(string id)
        {

        }
        public void getAccessToken(string id,string idApp, string )
        {
            FacebookClient fbClient = new FacebookClient();
            dynamic result = fbClient.Get("oauth/access_token", new
            {
                client_id = fbClient.AppId,
                client_secret = fbClient.AppSecret,
                
            });


        }
    }
   
}
