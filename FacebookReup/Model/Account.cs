using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookReup.Model
{
    class Account
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<Fanpage> listPage { get; set; }
        public List<Group> listGroup { get; set; }
    }
}
