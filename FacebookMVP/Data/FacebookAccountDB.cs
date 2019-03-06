using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FacebookMVP.Models;

namespace FacebookMVP.Data
{
    class FacebookAccountDB:DbContext
    {
        public DbSet<Account> Accounts { get; set; }
    }
}
