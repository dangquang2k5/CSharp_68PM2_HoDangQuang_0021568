namespace QuanLySinhVien
{
    partial class uc_qlsv
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
            this.btn_refresh_qlsv = new System.Windows.Forms.Button();
            this.btn_del_qlsv = new System.Windows.Forms.Button();
            this.btn_edit_qlsv = new System.Windows.Forms.Button();
            this.btn_add_qlsv = new System.Windows.Forms.Button();
            this.grb_ttsv = new System.Windows.Forms.GroupBox();
            this.cbb_lop = new System.Windows.Forms.ComboBox();
            this.cbb_gioitinh = new System.Windows.Forms.ComboBox();
            this.dtpicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_hvt = new System.Windows.Forms.TextBox();
            this.btn_quaylaitrangdau_qlsv = new System.Windows.Forms.Button();
            this.btn_quaylaitrangtruoc_qlsv = new System.Windows.Forms.Button();
            this.btn_chuyendentrangtiep_qlsv = new System.Windows.Forms.Button();
            this.btn_chuyendentrangcuoi_qlsv = new System.Windows.Forms.Button();
            this.dgv_qlsv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_search_qlsv = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_sotrang_qlsv = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grb_ttsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlsv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh_qlsv
            // 
            this.btn_refresh_qlsv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_refresh_qlsv.FlatAppearance.BorderSize = 0;
            this.btn_refresh_qlsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh_qlsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh_qlsv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refresh_qlsv.Location = new System.Drawing.Point(211, 609);
            this.btn_refresh_qlsv.Margin = new System.Windows.Forms.Padding(0);
            this.btn_refresh_qlsv.Name = "btn_refresh_qlsv";
            this.btn_refresh_qlsv.Size = new System.Drawing.Size(130, 50);
            this.btn_refresh_qlsv.TabIndex = 17;
            this.btn_refresh_qlsv.Text = "Làm mới";
            this.btn_refresh_qlsv.UseVisualStyleBackColor = false;
            this.btn_refresh_qlsv.Click += new System.EventHandler(this.btn_refresh_qlsv_Click);
            // 
            // btn_del_qlsv
            // 
            this.btn_del_qlsv.BackColor = System.Drawing.Color.Red;
            this.btn_del_qlsv.FlatAppearance.BorderSize = 0;
            this.btn_del_qlsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del_qlsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_qlsv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_del_qlsv.Location = new System.Drawing.Point(40, 609);
            this.btn_del_qlsv.Margin = new System.Windows.Forms.Padding(0);
            this.btn_del_qlsv.Name = "btn_del_qlsv";
            this.btn_del_qlsv.Size = new System.Drawing.Size(130, 50);
            this.btn_del_qlsv.TabIndex = 18;
            this.btn_del_qlsv.Text = "Xóa";
            this.btn_del_qlsv.UseVisualStyleBackColor = false;
            this.btn_del_qlsv.Click += new System.EventHandler(this.btn_del_qlsv_Click);
            // 
            // btn_edit_qlsv
            // 
            this.btn_edit_qlsv.BackColor = System.Drawing.Color.Cyan;
            this.btn_edit_qlsv.FlatAppearance.BorderSize = 0;
            this.btn_edit_qlsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_qlsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_qlsv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_edit_qlsv.Location = new System.Drawing.Point(211, 533);
            this.btn_edit_qlsv.Margin = new System.Windows.Forms.Padding(0);
            this.btn_edit_qlsv.Name = "btn_edit_qlsv";
            this.btn_edit_qlsv.Size = new System.Drawing.Size(130, 50);
            this.btn_edit_qlsv.TabIndex = 19;
            this.btn_edit_qlsv.Text = "Sửa";
            this.btn_edit_qlsv.UseVisualStyleBackColor = false;
            this.btn_edit_qlsv.Click += new System.EventHandler(this.btn_edit_qlsv_Click);
            // 
            // btn_add_qlsv
            // 
            this.btn_add_qlsv.BackColor = System.Drawing.Color.Lime;
            this.btn_add_qlsv.FlatAppearance.BorderSize = 0;
            this.btn_add_qlsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_qlsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_qlsv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_qlsv.Location = new System.Drawing.Point(40, 533);
            this.btn_add_qlsv.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add_qlsv.Name = "btn_add_qlsv";
            this.btn_add_qlsv.Size = new System.Drawing.Size(130, 50);
            this.btn_add_qlsv.TabIndex = 20;
            this.btn_add_qlsv.Text = "Thêm";
            this.btn_add_qlsv.UseVisualStyleBackColor = false;
            this.btn_add_qlsv.Click += new System.EventHandler(this.btn_add_qlsv_Click);
            // 
            // grb_ttsv
            // 
            this.grb_ttsv.Controls.Add(this.cbb_lop);
            this.grb_ttsv.Controls.Add(this.cbb_gioitinh);
            this.grb_ttsv.Controls.Add(this.dtpicker_ngaysinh);
            this.grb_ttsv.Controls.Add(this.label2);
            this.grb_ttsv.Controls.Add(this.txt_mssv);
            this.grb_ttsv.Controls.Add(this.label5);
            this.grb_ttsv.Controls.Add(this.label4);
            this.grb_ttsv.Controls.Add(this.label3);
            this.grb_ttsv.Controls.Add(this.label1);
            this.grb_ttsv.Controls.Add(this.txt_hvt);
            this.grb_ttsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ttsv.Location = new System.Drawing.Point(15, 19);
            this.grb_ttsv.Name = "grb_ttsv";
            this.grb_ttsv.Size = new System.Drawing.Size(354, 472);
            this.grb_ttsv.TabIndex = 16;
            this.grb_ttsv.TabStop = false;
            this.grb_ttsv.Text = "Thông tin sinh viên";
            // 
            // cbb_lop
            // 
            this.cbb_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.Location = new System.Drawing.Point(39, 334);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(277, 24);
            this.cbb_lop.TabIndex = 3;
            // 
            // cbb_gioitinh
            // 
            this.cbb_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_gioitinh.FormattingEnabled = true;
            this.cbb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_gioitinh.Location = new System.Drawing.Point(39, 261);
            this.cbb_gioitinh.Name = "cbb_gioitinh";
            this.cbb_gioitinh.Size = new System.Drawing.Size(277, 24);
            this.cbb_gioitinh.TabIndex = 3;
            // 
            // dtpicker_ngaysinh
            // 
            this.dtpicker_ngaysinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker_ngaysinh.Location = new System.Drawing.Point(40, 193);
            this.dtpicker_ngaysinh.Name = "dtpicker_ngaysinh";
            this.dtpicker_ngaysinh.Size = new System.Drawing.Size(277, 22);
            this.dtpicker_ngaysinh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên:";
            // 
            // txt_mssv
            // 
            this.txt_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mssv.Location = new System.Drawing.Point(39, 56);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(277, 22);
            this.txt_mssv.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên:";
            // 
            // txt_hvt
            // 
            this.txt_hvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hvt.Location = new System.Drawing.Point(39, 123);
            this.txt_hvt.Name = "txt_hvt";
            this.txt_hvt.Size = new System.Drawing.Size(277, 22);
            this.txt_hvt.TabIndex = 0;
            // 
            // btn_quaylaitrangdau_qlsv
            // 
            this.btn_quaylaitrangdau_qlsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylaitrangdau_qlsv.Location = new System.Drawing.Point(525, 653);
            this.btn_quaylaitrangdau_qlsv.Margin = new System.Windows.Forms.Padding(0);
            this.btn_quaylaitrangdau_qlsv.Name = "btn_quaylaitrangdau_qlsv";
            this.btn_quaylaitrangdau_qlsv.Size = new System.Drawing.Size(48, 48);
            this.btn_quaylaitrangdau_qlsv.TabIndex = 0;
            this.btn_quaylaitrangdau_qlsv.Text = "<<";
            this.btn_quaylaitrangdau_qlsv.UseVisualStyleBackColor = true;
            this.btn_quaylaitrangdau_qlsv.Click += new System.EventHandler(this.btn_quaylaitrangdau_qlsv_Click);
            // 
            // btn_quaylaitrangtruoc_qlsv
            // 
            this.btn_quaylaitrangtruoc_qlsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylaitrangtruoc_qlsv.Location = new System.Drawing.Point(573, 653);
            this.btn_quaylaitrangtruoc_qlsv.Margin = new System.Windows.Forms.Padding(0);
            this.btn_quaylaitrangtruoc_qlsv.Name = "btn_quaylaitrangtruoc_qlsv";
            this.btn_quaylaitrangtruoc_qlsv.Size = new System.Drawing.Size(35, 48);
            this.btn_quaylaitrangtruoc_qlsv.TabIndex = 1;
            this.btn_quaylaitrangtruoc_qlsv.Text = "<";
            this.btn_quaylaitrangtruoc_qlsv.UseVisualStyleBackColor = true;
            this.btn_quaylaitrangtruoc_qlsv.Click += new System.EventHandler(this.btn_quaylaitrangtruoc_qlsv_Click);
            // 
            // btn_chuyendentrangtiep_qlsv
            // 
            this.btn_chuyendentrangtiep_qlsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chuyendentrangtiep_qlsv.Location = new System.Drawing.Point(957, 653);
            this.btn_chuyendentrangtiep_qlsv.Margin = new System.Windows.Forms.Padding(0);
            this.btn_chuyendentrangtiep_qlsv.Name = "btn_chuyendentrangtiep_qlsv";
            this.btn_chuyendentrangtiep_qlsv.Size = new System.Drawing.Size(35, 48);
            this.btn_chuyendentrangtiep_qlsv.TabIndex = 1;
            this.btn_chuyendentrangtiep_qlsv.Text = ">";
            this.btn_chuyendentrangtiep_qlsv.UseVisualStyleBackColor = true;
            this.btn_chuyendentrangtiep_qlsv.Click += new System.EventHandler(this.btn_chuyendentrangtiep_qlsv_Click);
            // 
            // btn_chuyendentrangcuoi_qlsv
            // 
            this.btn_chuyendentrangcuoi_qlsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chuyendentrangcuoi_qlsv.Location = new System.Drawing.Point(992, 653);
            this.btn_chuyendentrangcuoi_qlsv.Margin = new System.Windows.Forms.Padding(0);
            this.btn_chuyendentrangcuoi_qlsv.Name = "btn_chuyendentrangcuoi_qlsv";
            this.btn_chuyendentrangcuoi_qlsv.Size = new System.Drawing.Size(48, 48);
            this.btn_chuyendentrangcuoi_qlsv.TabIndex = 0;
            this.btn_chuyendentrangcuoi_qlsv.Text = ">>";
            this.btn_chuyendentrangcuoi_qlsv.UseVisualStyleBackColor = true;
            this.btn_chuyendentrangcuoi_qlsv.Click += new System.EventHandler(this.btn_chuyendentrangcuoi_qlsv_Click);
            // 
            // dgv_qlsv
            // 
            this.dgv_qlsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_qlsv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_qlsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_qlsv.Location = new System.Drawing.Point(412, 92);
            this.dgv_qlsv.Name = "dgv_qlsv";
            this.dgv_qlsv.ReadOnly = true;
            this.dgv_qlsv.RowHeadersVisible = false;
            this.dgv_qlsv.RowHeadersWidth = 51;
            this.dgv_qlsv.RowTemplate.Height = 24;
            this.dgv_qlsv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_qlsv.Size = new System.Drawing.Size(753, 530);
            this.dgv_qlsv.TabIndex = 13;
            this.dgv_qlsv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_qlsv_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Mã SV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "hoten";
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "gioitinh";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngaysinh";
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "malop";
            this.Column5.HeaderText = "Lớp";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tìm kiếm:";
            // 
            // btn_search_qlsv
            // 
            this.btn_search_qlsv.BackColor = System.Drawing.Color.Lime;
            this.btn_search_qlsv.FlatAppearance.BorderSize = 0;
            this.btn_search_qlsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_qlsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_qlsv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search_qlsv.Location = new System.Drawing.Point(709, 30);
            this.btn_search_qlsv.Name = "btn_search_qlsv";
            this.btn_search_qlsv.Size = new System.Drawing.Size(120, 41);
            this.btn_search_qlsv.TabIndex = 12;
            this.btn_search_qlsv.Text = "Tìm kiếm";
            this.btn_search_qlsv.UseVisualStyleBackColor = false;
            this.btn_search_qlsv.Click += new System.EventHandler(this.btn_search_qlsv_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 22);
            this.textBox1.TabIndex = 10;
            // 
            // lbl_sotrang_qlsv
            // 
            this.lbl_sotrang_qlsv.AutoSize = true;
            this.lbl_sotrang_qlsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sotrang_qlsv.Location = new System.Drawing.Point(758, 664);
            this.lbl_sotrang_qlsv.Name = "lbl_sotrang_qlsv";
            this.lbl_sotrang_qlsv.Size = new System.Drawing.Size(32, 20);
            this.lbl_sotrang_qlsv.TabIndex = 21;
            this.lbl_sotrang_qlsv.Text = "1/1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(771, 664);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // uc_qlsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl_sotrang_qlsv);
            this.Controls.Add(this.btn_quaylaitrangdau_qlsv);
            this.Controls.Add(this.btn_quaylaitrangtruoc_qlsv);
            this.Controls.Add(this.btn_chuyendentrangtiep_qlsv);
            this.Controls.Add(this.btn_chuyendentrangcuoi_qlsv);
            this.Controls.Add(this.btn_refresh_qlsv);
            this.Controls.Add(this.btn_del_qlsv);
            this.Controls.Add(this.btn_edit_qlsv);
            this.Controls.Add(this.btn_add_qlsv);
            this.Controls.Add(this.grb_ttsv);
            this.Controls.Add(this.dgv_qlsv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_search_qlsv);
            this.Controls.Add(this.textBox1);
            this.Name = "uc_qlsv";
            this.Size = new System.Drawing.Size(1200, 750);
            this.Load += new System.EventHandler(this.uc_qlsv_Load);
            this.grb_ttsv.ResumeLayout(false);
            this.grb_ttsv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh_qlsv;
        private System.Windows.Forms.Button btn_del_qlsv;
        private System.Windows.Forms.Button btn_edit_qlsv;
        private System.Windows.Forms.Button btn_add_qlsv;
        private System.Windows.Forms.GroupBox grb_ttsv;
        private System.Windows.Forms.ComboBox cbb_lop;
        private System.Windows.Forms.ComboBox cbb_gioitinh;
        private System.Windows.Forms.DateTimePicker dtpicker_ngaysinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_hvt;
        private System.Windows.Forms.Button btn_quaylaitrangdau_qlsv;
        private System.Windows.Forms.Button btn_quaylaitrangtruoc_qlsv;
        private System.Windows.Forms.Button btn_chuyendentrangtiep_qlsv;
        private System.Windows.Forms.Button btn_chuyendentrangcuoi_qlsv;
        private System.Windows.Forms.DataGridView dgv_qlsv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_search_qlsv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lbl_sotrang_qlsv;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
