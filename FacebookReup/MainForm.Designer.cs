namespace FacebookReup
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnReup = new System.Windows.Forms.Button();
            this.dataGridViewPage = new System.Windows.Forms.DataGridView();
            this.checkBoxReup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.richtxtMessage = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFile = new System.Windows.Forms.Button();
            this.labelTypeFile = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReup
            // 
            this.btnReup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReup.Location = new System.Drawing.Point(533, 134);
            this.btnReup.Name = "btnReup";
            this.btnReup.Size = new System.Drawing.Size(75, 44);
            this.btnReup.TabIndex = 17;
            this.btnReup.Text = "Reup";
            this.btnReup.UseVisualStyleBackColor = true;
            this.btnReup.Click += new System.EventHandler(this.btnReup_Click);
            // 
            // dataGridViewPage
            // 
            this.dataGridViewPage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBoxReup});
            this.dataGridViewPage.Location = new System.Drawing.Point(25, 237);
            this.dataGridViewPage.Name = "dataGridViewPage";
            this.dataGridViewPage.Size = new System.Drawing.Size(1145, 345);
            this.dataGridViewPage.TabIndex = 21;
            // 
            // checkBoxReup
            // 
            this.checkBoxReup.HeaderText = "Chọn Page";
            this.checkBoxReup.Name = "checkBoxReup";
            // 
            // richtxtMessage
            // 
            this.richtxtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtMessage.Location = new System.Drawing.Point(130, 159);
            this.richtxtMessage.Name = "richtxtMessage";
            this.richtxtMessage.Size = new System.Drawing.Size(366, 72);
            this.richtxtMessage.TabIndex = 22;
            this.richtxtMessage.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Message";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(502, 184);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(138, 47);
            this.btnFile.TabIndex = 24;
            this.btnFile.Text = "Mo File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // labelTypeFile
            // 
            this.labelTypeFile.AutoSize = true;
            this.labelTypeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeFile.Location = new System.Drawing.Point(646, 204);
            this.labelTypeFile.Name = "labelTypeFile";
            this.labelTypeFile.Size = new System.Drawing.Size(89, 24);
            this.labelTypeFile.TabIndex = 25;
            this.labelTypeFile.Text = "Type File";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(638, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(130, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(419, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Thông báo:";
            // 
            // labelThongBao
            // 
            this.labelThongBao.AutoSize = true;
            this.labelThongBao.BackColor = System.Drawing.SystemColors.Info;
            this.labelThongBao.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelThongBao.Location = new System.Drawing.Point(545, 29);
            this.labelThongBao.Name = "labelThongBao";
            this.labelThongBao.Size = new System.Drawing.Size(162, 24);
            this.labelThongBao.TabIndex = 29;
            this.labelThongBao.Text = "Chưa đăng bài nào";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 613);
            this.Controls.Add(this.labelThongBao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelTypeFile);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richtxtMessage);
            this.Controls.Add(this.dataGridViewPage);
            this.Controls.Add(this.btnReup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Tool Reup Facebook";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReup;
        private System.Windows.Forms.DataGridView dataGridViewPage;
        private System.Windows.Forms.RichTextBox richtxtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label labelTypeFile;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxReup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelThongBao;
    }
}