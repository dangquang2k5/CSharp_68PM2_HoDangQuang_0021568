namespace QuanLySinhVien
{
    partial class frm_main
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
            this.pnl_main = new System.Windows.Forms.Panel();
            this.tstr_qlsv = new System.Windows.Forms.ToolStripMenuItem();
            this.tstr_qllh = new System.Windows.Forms.ToolStripMenuItem();
            this.tstr_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_main.Location = new System.Drawing.Point(14, 33);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1200, 750);
            this.pnl_main.TabIndex = 1;
            // 
            // tstr_qlsv
            // 
            this.tstr_qlsv.Name = "tstr_qlsv";
            this.tstr_qlsv.Size = new System.Drawing.Size(134, 24);
            this.tstr_qlsv.Text = "Quản lý sinh viên";
            this.tstr_qlsv.Click += new System.EventHandler(this.tstr_qlsv_Click);
            // 
            // tstr_qllh
            // 
            this.tstr_qllh.Name = "tstr_qllh";
            this.tstr_qllh.Size = new System.Drawing.Size(127, 24);
            this.tstr_qllh.Text = "Quản lý lớp học";
            this.tstr_qllh.Click += new System.EventHandler(this.tstr_qllh_Click);
            // 
            // tstr_logout
            // 
            this.tstr_logout.ForeColor = System.Drawing.Color.Red;
            this.tstr_logout.Name = "tstr_logout";
            this.tstr_logout.Size = new System.Drawing.Size(91, 24);
            this.tstr_logout.Text = "Đăng xuất";
            this.tstr_logout.Click += new System.EventHandler(this.tstr_logout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstr_qlsv,
            this.tstr_qllh,
            this.tstr_logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1226, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 795);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "frm_main";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.ToolStripMenuItem tstr_qlsv;
        private System.Windows.Forms.ToolStripMenuItem tstr_qllh;
        private System.Windows.Forms.ToolStripMenuItem tstr_logout;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}