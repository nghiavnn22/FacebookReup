using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDIDI
{
    class YahooMail : IEmailService
    {
        public void SendMail(string emailAdress, string message)
        {
            Console.WriteLine("yahoo"+emailAdress+message);
        }
    }
}
