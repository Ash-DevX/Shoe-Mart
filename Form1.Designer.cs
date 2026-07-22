namespace Shoe_Mart
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MIN_btn = new System.Windows.Forms.PictureBox();
            this.MAX_btn = new System.Windows.Forms.PictureBox();
            this.Exit_btn = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.Login_Pass_tb = new System.Windows.Forms.TextBox();
            this.Login_UName_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MIN_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAX_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // MIN_btn
            // 
            this.MIN_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MIN_btn.Image = ((System.Drawing.Image)(resources.GetObject("MIN_btn.Image")));
            this.MIN_btn.Location = new System.Drawing.Point(831, 12);
            this.MIN_btn.Name = "MIN_btn";
            this.MIN_btn.Size = new System.Drawing.Size(28, 30);
            this.MIN_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MIN_btn.TabIndex = 72;
            this.MIN_btn.TabStop = false;
            // 
            // MAX_btn
            // 
            this.MAX_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MAX_btn.Image = ((System.Drawing.Image)(resources.GetObject("MAX_btn.Image")));
            this.MAX_btn.Location = new System.Drawing.Point(874, 12);
            this.MAX_btn.Name = "MAX_btn";
            this.MAX_btn.Size = new System.Drawing.Size(28, 30);
            this.MAX_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MAX_btn.TabIndex = 71;
            this.MAX_btn.TabStop = false;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(918, 12);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(28, 30);
            this.Exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit_btn.TabIndex = 70;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(560, 342);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 68;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // login_btn
            // 
            this.login_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.login_btn.FlatAppearance.BorderSize = 2;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(355, 406);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(307, 33);
            this.login_btn.TabIndex = 64;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Login_Pass_tb
            // 
            this.Login_Pass_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_Pass_tb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Pass_tb.Location = new System.Drawing.Point(355, 290);
            this.Login_Pass_tb.Name = "Login_Pass_tb";
            this.Login_Pass_tb.PasswordChar = '*';
            this.Login_Pass_tb.Size = new System.Drawing.Size(307, 27);
            this.Login_Pass_tb.TabIndex = 63;
            // 
            // Login_UName_tb
            // 
            this.Login_UName_tb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_UName_tb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_UName_tb.Location = new System.Drawing.Point(355, 231);
            this.Login_UName_tb.Name = "Login_UName_tb";
            this.Login_UName_tb.Size = new System.Drawing.Size(307, 27);
            this.Login_UName_tb.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 61;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 60;
            this.label3.Text = "User Name";
            // 
            // login_txt
            // 
            this.login_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_txt.AutoSize = true;
            this.login_txt.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_txt.Location = new System.Drawing.Point(383, 116);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(175, 35);
            this.login_txt.TabIndex = 59;
            this.login_txt.Text = "Login page";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Shoe_Mart.Properties.Resources._8bb800ce55e3316f79c2f2ffc5f54881;
            this.ClientSize = new System.Drawing.Size(958, 608);
            this.Controls.Add(this.MIN_btn);
            this.Controls.Add(this.MAX_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.Login_Pass_tb);
            this.Controls.Add(this.Login_UName_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MIN_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAX_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MIN_btn;
        private System.Windows.Forms.PictureBox MAX_btn;
        private System.Windows.Forms.PictureBox Exit_btn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox Login_Pass_tb;
        private System.Windows.Forms.TextBox Login_UName_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label login_txt;
    }
}

