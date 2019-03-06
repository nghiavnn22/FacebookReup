using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDIDI
{
    class UserLogic
    {
        private GoogleOAuthService _authoService;
        private IEmailService _emailService;
        public UserLogic()
        {
            _authoService = new GoogleOAuthService();
            _emailService = new YahooMail();
        }
        
    }
   
}
