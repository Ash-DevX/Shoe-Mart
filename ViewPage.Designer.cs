namespace Shoe_Mart
{
    partial class ViewPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPage));
            this.MIN_btn = new System.Windows.Forms.PictureBox();
            this.MAX_btn = new System.Windows.Forms.PictureBox();
            this.Exit_btn = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.AddU_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MIN_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAX_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MIN_btn
            // 
            this.MIN_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MIN_btn.Image = ((System.Drawing.Image)(resources.GetObject("MIN_btn.Image")));
            this.MIN_btn.Location = new System.Drawing.Point(952, 12);
            this.MIN_btn.Name = "MIN_btn";
            this.MIN_btn.Size = new System.Drawing.Size(28, 30);
            this.MIN_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MIN_btn.TabIndex = 75;
            this.MIN_btn.TabStop = false;
            this.MIN_btn.Click += new System.EventHandler(this.MIN_btn_Click);
            // 
            // MAX_btn
            // 
            this.MAX_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MAX_btn.Image = ((System.Drawing.Image)(resources.GetObject("MAX_btn.Image")));
            this.MAX_btn.Location = new System.Drawing.Point(995, 12);
            this.MAX_btn.Name = "MAX_btn";
            this.MAX_btn.Size = new System.Drawing.Size(28, 30);
            this.MAX_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MAX_btn.TabIndex = 74;
            this.MAX_btn.TabStop = false;
            this.MAX_btn.Click += new System.EventHandler(this.MAX_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("Exit_btn.Image")));
            this.Exit_btn.Location = new System.Drawing.Point(1039, 12);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(28, 30);
            this.Exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit_btn.TabIndex = 73;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 359);
            this.dataGridView1.TabIndex = 76;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(483, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 85;
            this.button1.Text = "View Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddU_txt
            // 
            this.AddU_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddU_txt.AutoSize = true;
            this.AddU_txt.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddU_txt.Location = new System.Drawing.Point(441, 56);
            this.AddU_txt.Name = "AddU_txt";
            this.AddU_txt.Size = new System.Drawing.Size(191, 35);
            this.AddU_txt.TabIndex = 86;
            this.AddU_txt.Text = "User Details";
            // 
            // ViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 659);
            this.Controls.Add(this.AddU_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MIN_btn);
            this.Controls.Add(this.MAX_btn);
            this.Controls.Add(this.Exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPage";
            ((System.ComponentModel.ISupportInitialize)(this.MIN_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAX_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MIN_btn;
        private System.Windows.Forms.PictureBox MAX_btn;
        private System.Windows.Forms.PictureBox Exit_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AddU_txt;
    }
}