using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDIDI
{
    interface IEmailService
    {
        void SendMail(string emailAdress, string message);
    }
}
