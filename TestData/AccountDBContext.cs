using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace TestData
{
    public class AccountDBContext:DbContext
    {
        public DbSet<Account> accounts { get; set; }
    }
}
