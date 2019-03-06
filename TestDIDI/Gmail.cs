using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDIDI
{
    class Gmail : IEmailService
    {
        public void SendMail(string emailAdress, string message)
        {
            Console.Write("Noi dung: "+ message + "Dia chi"+emailAdress);
        }
    }
}
