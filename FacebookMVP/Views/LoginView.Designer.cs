namespace FacebookMVP.Views
{
    partial class LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.facebookDataSet = new FacebookMVP.FacebookDataSet();
            this.facebookaccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facebookaccountTableAdapter = new FacebookMVP.FacebookDataSetTableAdapters.facebookaccountTableAdapter();
            this.btnLoginWithCookie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookaccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(118, 62);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(181, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(118, 104);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(344, 60);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 60);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(72, 172);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(527, 150);
            this.dgvAccount.TabIndex = 5;
            // 
            // facebookDataSet
            // 
            this.facebookDataSet.DataSetName = "FacebookDataSet";
            this.facebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facebookaccountBindingSource
            // 
            this.facebookaccountBindingSource.DataMember = "facebookaccount";
            this.facebookaccountBindingSource.DataSource = this.facebookDataSet;
            // 
            // facebookaccountTableAdapter
            // 
            this.facebookaccountTableAdapter.ClearBeforeFill = true;
            // 
            // btnLoginWithCookie
            // 
            this.btnLoginWithCookie.Location = new System.Drawing.Point(524, 54);
            this.btnLoginWithCookie.Name = "btnLoginWithCookie";
            this.btnLoginWithCookie.Size = new System.Drawing.Size(75, 66);
            this.btnLoginWithCookie.TabIndex = 6;
            this.btnLoginWithCookie.Text = "Login with cookie";
            this.btnLoginWithCookie.UseVisualStyleBackColor = true;
            this.btnLoginWithCookie.Click += new System.EventHandler(this.btnLoginWithCookie_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoginWithCookie);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.Load += new System.EventHandler(this.LoginView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookaccountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DataGridView dgvAccount;
        private FacebookDataSet facebookDataSet;
        private System.Windows.Forms.BindingSource facebookaccountBindingSource;
        private FacebookDataSetTableAdapters.facebookaccountTableAdapter facebookaccountTableAdapter;
        private System.Windows.Forms.Button btnLoginWithCookie;
    }
}