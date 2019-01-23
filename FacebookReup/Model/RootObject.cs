using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookReup.Model
{


    public class Datum
    {
        public string id { get; set; }
        public string name { get; set; }
        public string access_token { get; set; }
    }

    public class Cursors
    {
        public string before { get; set; }
        public string after { get; set; }
    }

    public class Paging
    {
        public Cursors cursors { get; set; }
    }

    public class RootObject
    {
        public List<Datum> data { get; set; }
        public Paging paging { get; set; }
    }
}
