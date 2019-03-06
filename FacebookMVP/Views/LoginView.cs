using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookMVP.Views;
using FacebookMVP.Presenter;
using System.Windows.Forms;
using FacebookMVP.Data;
using FacebookMVP.Models;

namespace FacebookMVP.Views
{
    public partial class LoginView : Form ,IMainLogin
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public string Username { get { return txtUsername.Text; } set { txtUsername.Text = value; } }

        public string Password { get { return txtPassword.Text; } set { txtPassword.Text = value; } }

        public object DataGridViewAccount { get { return dgvAccount.DataSource; }   set { dgvAccount.DataSource = value; } }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginPresenter presenter = new LoginPresenter(this);
            presenter.loginFacebook();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            LoginPresenter presenter = new LoginPresenter(this);
            presenter.loadAccount();
        }

        private void btnLoginWithCookie_Click(object sender, EventArgs e)
        {
            LoginPresenter presenter = new LoginPresenter(this);
            Account account = new Account();
            using (var db = new FacebookAccountDB())
            {
                account = db.Accounts.SingleOrDefault(a=>a.username==Username);
            }
            presenter.loginWithCookie(account);
        }
    }
}
