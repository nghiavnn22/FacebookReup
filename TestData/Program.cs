using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account a1 = new Account {username = "ngan", password = "dfasd",name="nghia",cookie="dd",session="33" };
            Console.WriteLine("hehehehe");
            using (var db = new AccountDBContext())
            {
                List<Account> list = db.accounts.ToList();
                foreach (var account in list)
                {
                    Console.WriteLine(account.username.ToString());
                }
                
            }
            
        }
    }
}
