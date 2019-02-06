using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using System.Management;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime time = dateTimePicker1.Value;
            string timeunix = ((DateTimeOffset)time).ToUnixTimeMilliseconds().ToString();
            textBox1.Text = timeunix;
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            FacebookClient client = new FacebookClient(txtGroup.Text);
            dynamic groups = client.Get("/me/groups/fields=name,id,member.limit(0).summary(true)&limit=1000");
            int groupcount = Convert.ToInt32(groups.data.Count);
            for (int i = 0; i < groupcount; i++)
            {
                string groupid = groups.data[i].id;
                string groupname = groups.data[i].name;
                string member = groups.data[i].members.summary.total_count.toString();
                ListViewItem item = new ListViewItem();
                item.Text = groupid;
                item.SubItems.Add(groupname);
                item.SubItems.Add(groupid);
                listView1.Items.Add(item);
            }
        }
    }
}
