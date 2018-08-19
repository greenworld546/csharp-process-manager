namespace AppMinimizer
{
    partial class ProcessManagerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessManagerFrm));
            this.HideBtn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.KillBtn = new System.Windows.Forms.Button();
            this.ProcessList = new System.Windows.Forms.ListBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileLocationTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowProcessInfoBtn = new System.Windows.Forms.Button();
            this.ErrorTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HideBtn
            // 
            this.HideBtn.BackColor = System.Drawing.Color.Green;
            this.HideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideBtn.ForeColor = System.Drawing.Color.White;
            this.HideBtn.Location = new System.Drawing.Point(3, 313);
            this.HideBtn.Name = "HideBtn";
            this.HideBtn.Size = new System.Drawing.Size(75, 23);
            this.HideBtn.TabIndex = 0;
            this.HideBtn.Text = "Hide";
            this.HideBtn.UseVisualStyleBackColor = false;
            this.HideBtn.Click += new System.EventHandler(this.HideBtn_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.BackColor = System.Drawing.Color.Green;
            this.ShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowBtn.ForeColor = System.Drawing.Color.White;
            this.ShowBtn.Location = new System.Drawing.Point(84, 313);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowBtn.TabIndex = 1;
            this.ShowBtn.Text = "Show";
            this.ShowBtn.UseVisualStyleBackColor = false;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // KillBtn
            // 
            this.KillBtn.BackColor = System.Drawing.Color.Green;
            this.KillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KillBtn.ForeColor = System.Drawing.Color.White;
            this.KillBtn.Location = new System.Drawing.Point(165, 313);
            this.KillBtn.Name = "KillBtn";
            this.KillBtn.Size = new System.Drawing.Size(75, 23);
            this.KillBtn.TabIndex = 2;
            this.KillBtn.Text = "Kill";
            this.KillBtn.UseVisualStyleBackColor = false;
            this.KillBtn.Click += new System.EventHandler(this.KillBtn_Click);
            // 
            // ProcessList
            // 
            this.ProcessList.FormattingEnabled = true;
            this.ProcessList.Location = new System.Drawing.Point(3, 12);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(237, 290);
            this.ProcessList.TabIndex = 3;
            this.ProcessList.SelectedIndexChanged += new System.EventHandler(this.ProcessList_SelectedIndexChanged);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.Green;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Location = new System.Drawing.Point(246, 12);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 4;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileLocationTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(246, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ProcessInfo";
            // 
            // FileLocationTxt
            // 
            this.FileLocationTxt.Location = new System.Drawing.Point(92, 23);
            this.FileLocationTxt.Name = "FileLocationTxt";
            this.FileLocationTxt.ReadOnly = true;
            this.FileLocationTxt.Size = new System.Drawing.Size(299, 20);
            this.FileLocationTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FileLocation";
            // 
            // ShowProcessInfoBtn
            // 
            this.ShowProcessInfoBtn.BackColor = System.Drawing.Color.Green;
            this.ShowProcessInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowProcessInfoBtn.ForeColor = System.Drawing.Color.White;
            this.ShowProcessInfoBtn.Location = new System.Drawing.Point(325, 12);
            this.ShowProcessInfoBtn.Name = "ShowProcessInfoBtn";
            this.ShowProcessInfoBtn.Size = new System.Drawing.Size(106, 23);
            this.ShowProcessInfoBtn.TabIndex = 6;
            this.ShowProcessInfoBtn.Text = "ShowProcessInfo";
            this.ShowProcessInfoBtn.UseVisualStyleBackColor = false;
            this.ShowProcessInfoBtn.Click += new System.EventHandler(this.ShowProcessInfoBtn_Click);
            // 
            // ErrorTxt
            // 
            this.ErrorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorTxt.ForeColor = System.Drawing.Color.Red;
            this.ErrorTxt.Location = new System.Drawing.Point(246, 106);
            this.ErrorTxt.Multiline = true;
            this.ErrorTxt.Name = "ErrorTxt";
            this.ErrorTxt.ReadOnly = true;
            this.ErrorTxt.Size = new System.Drawing.Size(397, 196);
            this.ErrorTxt.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(521, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ProcessManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(655, 348);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ErrorTxt);
            this.Controls.Add(this.ShowProcessInfoBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.ProcessList);
            this.Controls.Add(this.KillBtn);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.HideBtn);
            this.Name = "ProcessManagerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcessManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HideBtn;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Button KillBtn;
        private System.Windows.Forms.ListBox ProcessList;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileLocationTxt;
        private System.Windows.Forms.Button ShowProcessInfoBtn;
        private System.Windows.Forms.TextBox ErrorTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

