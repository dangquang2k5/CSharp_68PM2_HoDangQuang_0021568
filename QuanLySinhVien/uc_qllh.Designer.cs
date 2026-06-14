namespace QuanLySinhVien
{
    partial class uc_qllh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_qllh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maID_qllh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_malop_qllh = new System.Windows.Forms.TextBox();
            this.btn_quaylaitrangdau_qllh = new System.Windows.Forms.Button();
            this.btn_quaylaitrangtruoc_qllh = new System.Windows.Forms.Button();
            this.btn_chuyendentrangtiep_qllh = new System.Windows.Forms.Button();
            this.btn_chuyendentrangcuoi_qllh = new System.Windows.Forms.Button();
            this.btn_refresh_qllh = new System.Windows.Forms.Button();
            this.btn_del_qllh = new System.Windows.Forms.Button();
            this.btn_edit_qllh = new System.Windows.Forms.Button();
            this.btn_add_qllh = new System.Windows.Forms.Button();
            this.grb_ttsv = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt__tenlop_qllh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ghichu_qllh = new System.Windows.Forms.TextBox();
            this.btn_search_qllh = new System.Windows.Forms.Button();
            this.btn_xemdssv_qllh = new System.Windows.Forms.Button();
            this.lbl_sotrang_qllh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qllh)).BeginInit();
            this.grb_ttsv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_qllh
            // 
            this.dgv_qllh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_qllh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_qllh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qllh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_qllh.Location = new System.Drawing.Point(412, 92);
            this.dgv_qllh.Name = "dgv_qllh";
            this.dgv_qllh.ReadOnly = true;
            this.dgv_qllh.RowHeadersVisible = false;
            this.dgv_qllh.RowHeadersWidth = 51;
            this.dgv_qllh.RowTemplate.Height = 24;
            this.dgv_qllh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_qllh.Size = new System.Drawing.Size(753, 530);
            this.dgv_qllh.TabIndex = 28;
            this.dgv_qllh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qllh_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Mã ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "malop";
            this.Column2.HeaderText = "Mã lớp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tenlop";
            this.Column3.HeaderText = "Tên lớp";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ghichu";
            this.Column4.HeaderText = "Ghi chú";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã ID:";
            // 
            // txt_maID_qllh
            // 
            this.txt_maID_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maID_qllh.Location = new System.Drawing.Point(40, 56);
            this.txt_maID_qllh.Name = "txt_maID_qllh";
            this.txt_maID_qllh.Size = new System.Drawing.Size(277, 22);
            this.txt_maID_qllh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã lớp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 22);
            this.textBox1.TabIndex = 25;
            // 
            // txt_malop_qllh
            // 
            this.txt_malop_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_malop_qllh.Location = new System.Drawing.Point(40, 132);
            this.txt_malop_qllh.Name = "txt_malop_qllh";
            this.txt_malop_qllh.Size = new System.Drawing.Size(277, 22);
            this.txt_malop_qllh.TabIndex = 0;
            // 
            // btn_quaylaitrangdau_qllh
            // 
            this.btn_quaylaitrangdau_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylaitrangdau_qllh.Location = new System.Drawing.Point(525, 653);
            this.btn_quaylaitrangdau_qllh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_quaylaitrangdau_qllh.Name = "btn_quaylaitrangdau_qllh";
            this.btn_quaylaitrangdau_qllh.Size = new System.Drawing.Size(48, 48);
            this.btn_quaylaitrangdau_qllh.TabIndex = 21;
            this.btn_quaylaitrangdau_qllh.Text = "<<";
            this.btn_quaylaitrangdau_qllh.UseVisualStyleBackColor = true;
            this.btn_quaylaitrangdau_qllh.Click += new System.EventHandler(this.btn_quaylaitrangdau_qllh_Click);
            // 
            // btn_quaylaitrangtruoc_qllh
            // 
            this.btn_quaylaitrangtruoc_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylaitrangtruoc_qllh.Location = new System.Drawing.Point(573, 653);
            this.btn_quaylaitrangtruoc_qllh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_quaylaitrangtruoc_qllh.Name = "btn_quaylaitrangtruoc_qllh";
            this.btn_quaylaitrangtruoc_qllh.Size = new System.Drawing.Size(35, 48);
            this.btn_quaylaitrangtruoc_qllh.TabIndex = 23;
            this.btn_quaylaitrangtruoc_qllh.Text = "<";
            this.btn_quaylaitrangtruoc_qllh.UseVisualStyleBackColor = true;
            this.btn_quaylaitrangtruoc_qllh.Click += new System.EventHandler(this.btn_quaylaitrangtruoc_qllh_Click);
            // 
            // btn_chuyendentrangtiep_qllh
            // 
            this.btn_chuyendentrangtiep_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chuyendentrangtiep_qllh.Location = new System.Drawing.Point(957, 653);
            this.btn_chuyendentrangtiep_qllh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_chuyendentrangtiep_qllh.Name = "btn_chuyendentrangtiep_qllh";
            this.btn_chuyendentrangtiep_qllh.Size = new System.Drawing.Size(35, 48);
            this.btn_chuyendentrangtiep_qllh.TabIndex = 24;
            this.btn_chuyendentrangtiep_qllh.Text = ">";
            this.btn_chuyendentrangtiep_qllh.UseVisualStyleBackColor = true;
            this.btn_chuyendentrangtiep_qllh.Click += new System.EventHandler(this.btn_chuyendentrangtiep_qllh_Click);
            // 
            // btn_chuyendentrangcuoi_qllh
            // 
            this.btn_chuyendentrangcuoi_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chuyendentrangcuoi_qllh.Location = new System.Drawing.Point(992, 653);
            this.btn_chuyendentrangcuoi_qllh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_chuyendentrangcuoi_qllh.Name = "btn_chuyendentrangcuoi_qllh";
            this.btn_chuyendentrangcuoi_qllh.Size = new System.Drawing.Size(48, 48);
            this.btn_chuyendentrangcuoi_qllh.TabIndex = 22;
            this.btn_chuyendentrangcuoi_qllh.Text = ">>";
            this.btn_chuyendentrangcuoi_qllh.UseVisualStyleBackColor = true;
            this.btn_chuyendentrangcuoi_qllh.Click += new System.EventHandler(this.btn_chuyendentrangcuoi_qllh_Click);
            // 
            // btn_refresh_qllh
            // 
            this.btn_refresh_qllh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_refresh_qllh.FlatAppearance.BorderSize = 0;
            this.btn_refresh_qllh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh_qllh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refresh_qllh.Location = new System.Drawing.Point(211, 558);
            this.btn_refresh_qllh.Name = "btn_refresh_qllh";
            this.btn_refresh_qllh.Size = new System.Drawing.Size(130, 50);
            this.btn_refresh_qllh.TabIndex = 31;
            this.btn_refresh_qllh.Text = "Làm mới";
            this.btn_refresh_qllh.UseVisualStyleBackColor = false;
            this.btn_refresh_qllh.Click += new System.EventHandler(this.btn_refresh_qllh_Click);
            // 
            // btn_del_qllh
            // 
            this.btn_del_qllh.BackColor = System.Drawing.Color.Red;
            this.btn_del_qllh.FlatAppearance.BorderSize = 0;
            this.btn_del_qllh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_qllh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_del_qllh.Location = new System.Drawing.Point(40, 558);
            this.btn_del_qllh.Name = "btn_del_qllh";
            this.btn_del_qllh.Size = new System.Drawing.Size(130, 50);
            this.btn_del_qllh.TabIndex = 32;
            this.btn_del_qllh.Text = "Xóa";
            this.btn_del_qllh.UseVisualStyleBackColor = false;
            this.btn_del_qllh.Click += new System.EventHandler(this.btn_del_qllh_Click);
            // 
            // btn_edit_qllh
            // 
            this.btn_edit_qllh.BackColor = System.Drawing.Color.Cyan;
            this.btn_edit_qllh.FlatAppearance.BorderSize = 0;
            this.btn_edit_qllh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_qllh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit_qllh.Location = new System.Drawing.Point(211, 482);
            this.btn_edit_qllh.Name = "btn_edit_qllh";
            this.btn_edit_qllh.Size = new System.Drawing.Size(130, 50);
            this.btn_edit_qllh.TabIndex = 33;
            this.btn_edit_qllh.Text = "Sửa";
            this.btn_edit_qllh.UseVisualStyleBackColor = false;
            this.btn_edit_qllh.Click += new System.EventHandler(this.btn_edit_qllh_Click);
            // 
            // btn_add_qllh
            // 
            this.btn_add_qllh.BackColor = System.Drawing.Color.Lime;
            this.btn_add_qllh.FlatAppearance.BorderSize = 0;
            this.btn_add_qllh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_qllh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_qllh.Location = new System.Drawing.Point(40, 482);
            this.btn_add_qllh.Name = "btn_add_qllh";
            this.btn_add_qllh.Size = new System.Drawing.Size(130, 50);
            this.btn_add_qllh.TabIndex = 34;
            this.btn_add_qllh.Text = "Thêm";
            this.btn_add_qllh.UseVisualStyleBackColor = false;
            this.btn_add_qllh.Click += new System.EventHandler(this.btn_add_qllh_Click);
            // 
            // grb_ttsv
            // 
            this.grb_ttsv.Controls.Add(this.label4);
            this.grb_ttsv.Controls.Add(this.label2);
            this.grb_ttsv.Controls.Add(this.txt__tenlop_qllh);
            this.grb_ttsv.Controls.Add(this.label3);
            this.grb_ttsv.Controls.Add(this.txt_maID_qllh);
            this.grb_ttsv.Controls.Add(this.txt_ghichu_qllh);
            this.grb_ttsv.Controls.Add(this.label1);
            this.grb_ttsv.Controls.Add(this.txt_malop_qllh);
            this.grb_ttsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ttsv.Location = new System.Drawing.Point(13, 18);
            this.grb_ttsv.Name = "grb_ttsv";
            this.grb_ttsv.Size = new System.Drawing.Size(358, 406);
            this.grb_ttsv.TabIndex = 30;
            this.grb_ttsv.TabStop = false;
            this.grb_ttsv.Text = "Thông tin lớp học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên lớp:";
            // 
            // txt__tenlop_qllh
            // 
            this.txt__tenlop_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt__tenlop_qllh.Location = new System.Drawing.Point(40, 213);
            this.txt__tenlop_qllh.Name = "txt__tenlop_qllh";
            this.txt__tenlop_qllh.Size = new System.Drawing.Size(277, 22);
            this.txt__tenlop_qllh.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ghi chú:";
            // 
            // txt_ghichu_qllh
            // 
            this.txt_ghichu_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghichu_qllh.Location = new System.Drawing.Point(40, 289);
            this.txt_ghichu_qllh.Name = "txt_ghichu_qllh";
            this.txt_ghichu_qllh.Size = new System.Drawing.Size(277, 22);
            this.txt_ghichu_qllh.TabIndex = 0;
            // 
            // btn_search_qllh
            // 
            this.btn_search_qllh.BackColor = System.Drawing.Color.Lime;
            this.btn_search_qllh.FlatAppearance.BorderSize = 0;
            this.btn_search_qllh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_qllh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search_qllh.Location = new System.Drawing.Point(709, 30);
            this.btn_search_qllh.Name = "btn_search_qllh";
            this.btn_search_qllh.Size = new System.Drawing.Size(120, 41);
            this.btn_search_qllh.TabIndex = 27;
            this.btn_search_qllh.Text = "Tìm kiếm";
            this.btn_search_qllh.UseVisualStyleBackColor = false;
            this.btn_search_qllh.Click += new System.EventHandler(this.btn_search_qllh_Click);
            // 
            // btn_xemdssv_qllh
            // 
            this.btn_xemdssv_qllh.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_xemdssv_qllh.FlatAppearance.BorderSize = 0;
            this.btn_xemdssv_qllh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xemdssv_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemdssv_qllh.Location = new System.Drawing.Point(37, 631);
            this.btn_xemdssv_qllh.Name = "btn_xemdssv_qllh";
            this.btn_xemdssv_qllh.Size = new System.Drawing.Size(304, 43);
            this.btn_xemdssv_qllh.TabIndex = 35;
            this.btn_xemdssv_qllh.Text = "Xem danh sách sinh viên";
            this.btn_xemdssv_qllh.UseVisualStyleBackColor = false;
            this.btn_xemdssv_qllh.Click += new System.EventHandler(this.btn_xemdssv_qllh_Click);
            // 
            // lbl_sotrang_qllh
            // 
            this.lbl_sotrang_qllh.AutoSize = true;
            this.lbl_sotrang_qllh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sotrang_qllh.Location = new System.Drawing.Point(758, 664);
            this.lbl_sotrang_qllh.Name = "lbl_sotrang_qllh";
            this.lbl_sotrang_qllh.Size = new System.Drawing.Size(32, 20);
            this.lbl_sotrang_qllh.TabIndex = 36;
            this.lbl_sotrang_qllh.Text = "1/1";
            // 
            // uc_qllh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_sotrang_qllh);
            this.Controls.Add(this.btn_xemdssv_qllh);
            this.Controls.Add(this.dgv_qllh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_quaylaitrangdau_qllh);
            this.Controls.Add(this.btn_quaylaitrangtruoc_qllh);
            this.Controls.Add(this.btn_chuyendentrangtiep_qllh);
            this.Controls.Add(this.btn_chuyendentrangcuoi_qllh);
            this.Controls.Add(this.btn_refresh_qllh);
            this.Controls.Add(this.btn_del_qllh);
            this.Controls.Add(this.btn_edit_qllh);
            this.Controls.Add(this.btn_add_qllh);
            this.Controls.Add(this.grb_ttsv);
            this.Controls.Add(this.btn_search_qllh);
            this.Name = "uc_qllh";
            this.Size = new System.Drawing.Size(1200, 750);
            this.Load += new System.EventHandler(this.uc_qllh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qllh)).EndInit();
            this.grb_ttsv.ResumeLayout(false);
            this.grb_ttsv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_qllh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maID_qllh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_malop_qllh;
        private System.Windows.Forms.Button btn_quaylaitrangdau_qllh;
        private System.Windows.Forms.Button btn_quaylaitrangtruoc_qllh;
        private System.Windows.Forms.Button btn_chuyendentrangtiep_qllh;
        private System.Windows.Forms.Button btn_chuyendentrangcuoi_qllh;
        private System.Windows.Forms.Button btn_refresh_qllh;
        private System.Windows.Forms.Button btn_del_qllh;
        private System.Windows.Forms.Button btn_edit_qllh;
        private System.Windows.Forms.Button btn_add_qllh;
        private System.Windows.Forms.GroupBox grb_ttsv;
        private System.Windows.Forms.Button btn_search_qllh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt__tenlop_qllh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ghichu_qllh;
        private System.Windows.Forms.Button btn_xemdssv_qllh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lbl_sotrang_qllh;
    }
}
