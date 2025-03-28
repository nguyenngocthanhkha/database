namespace kha_bai1
{
    partial class bai_so_2
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
            label1 = new Label();
            txtMSSV = new Label();
            textBox1 = new TextBox();
            txtHoVaTen = new Label();
            textBox2 = new TextBox();
            txtNienKhoa = new Label();
            cboNienKhoa = new ComboBox();
            txtLop = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            comboBox2 = new ComboBox();
            txtHocKy = new Label();
            rdoI = new RadioButton();
            rdoII = new RadioButton();
            radioButton3 = new RadioButton();
            txtMonHoc = new Label();
            clbMonHoc = new CheckedListBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(207, 62);
            label1.Name = "label1";
            label1.Size = new Size(271, 35);
            label1.TabIndex = 0;
            label1.Text = "Đăng Ký Môn Học";
            // 
            // txtMSSV
            // 
            txtMSSV.AutoSize = true;
            txtMSSV.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMSSV.Location = new Point(145, 175);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(60, 20);
            txtMSSV.TabIndex = 1;
            txtMSSV.Text = "MSSV";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 175);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 2;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.AutoSize = true;
            txtHoVaTen.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHoVaTen.Location = new Point(132, 241);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(91, 23);
            txtHoVaTen.TabIndex = 3;
            txtHoVaTen.Text = "Họ và tên";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(254, 238);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // txtNienKhoa
            // 
            txtNienKhoa.AutoSize = true;
            txtNienKhoa.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNienKhoa.Location = new Point(127, 311);
            txtNienKhoa.Name = "txtNienKhoa";
            txtNienKhoa.Size = new Size(92, 20);
            txtNienKhoa.TabIndex = 5;
            txtNienKhoa.Text = "Niên khóa";
            // 
            // cboNienKhoa
            // 
            cboNienKhoa.FormattingEnabled = true;
            cboNienKhoa.Location = new Point(254, 311);
            cboNienKhoa.Margin = new Padding(3, 4, 3, 4);
            cboNienKhoa.Name = "cboNienKhoa";
            cboNienKhoa.Size = new Size(200, 28);
            cboNienKhoa.TabIndex = 6;
            // 
            // txtLop
            // 
            txtLop.AutoSize = true;
            txtLop.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLop.Location = new Point(147, 370);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(48, 25);
            txtLop.TabIndex = 7;
            txtLop.Text = "Lớp";
            txtLop.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(254, 370);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 28);
            comboBox2.TabIndex = 8;
            // 
            // txtHocKy
            // 
            txtHocKy.AutoSize = true;
            txtHocKy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHocKy.Location = new Point(132, 431);
            txtHocKy.Name = "txtHocKy";
            txtHocKy.Size = new Size(84, 25);
            txtHocKy.TabIndex = 9;
            txtHocKy.Text = "Học kỳ ";
            // 
            // rdoI
            // 
            rdoI.AutoSize = true;
            rdoI.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoI.Location = new Point(263, 429);
            rdoI.Margin = new Padding(3, 4, 3, 4);
            rdoI.Name = "rdoI";
            rdoI.Size = new Size(35, 24);
            rdoI.TabIndex = 10;
            rdoI.TabStop = true;
            rdoI.Text = "I";
            rdoI.UseVisualStyleBackColor = true;
            // 
            // rdoII
            // 
            rdoII.AutoSize = true;
            rdoII.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoII.Location = new Point(381, 429);
            rdoII.Margin = new Padding(3, 4, 3, 4);
            rdoII.Name = "rdoII";
            rdoII.Size = new Size(40, 24);
            rdoII.TabIndex = 11;
            rdoII.TabStop = true;
            rdoII.Text = "II";
            rdoII.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(492, 429);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(45, 24);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "III";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // txtMonHoc
            // 
            txtMonHoc.AutoSize = true;
            txtMonHoc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMonHoc.Location = new Point(127, 490);
            txtMonHoc.Name = "txtMonHoc";
            txtMonHoc.Size = new Size(104, 25);
            txtMonHoc.TabIndex = 13;
            txtMonHoc.Text = "Môn Học ";
            // 
            // clbMonHoc
            // 
            clbMonHoc.FormattingEnabled = true;
            clbMonHoc.Items.AddRange(new object[] { "Lập Trình Window", "Lập trình Internet", "Mạng máy tính ", "UML" });
            clbMonHoc.Location = new Point(254, 490);
            clbMonHoc.Margin = new Padding(3, 4, 3, 4);
            clbMonHoc.Name = "clbMonHoc";
            clbMonHoc.Size = new Size(285, 114);
            clbMonHoc.TabIndex = 14;
            clbMonHoc.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // btnDangKy
            // 
            btnDangKy.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.Location = new Point(127, 627);
            btnDangKy.Margin = new Padding(3, 4, 3, 4);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(100, 52);
            btnDangKy.TabIndex = 15;
            btnDangKy.Text = "Đăng Ký ";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += button1_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(309, 627);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(100, 52);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(492, 627);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 52);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // bai_so_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(714, 688);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(clbMonHoc);
            Controls.Add(txtMonHoc);
            Controls.Add(radioButton3);
            Controls.Add(rdoII);
            Controls.Add(rdoI);
            Controls.Add(txtHocKy);
            Controls.Add(comboBox2);
            Controls.Add(txtLop);
            Controls.Add(cboNienKhoa);
            Controls.Add(txtNienKhoa);
            Controls.Add(textBox2);
            Controls.Add(txtHoVaTen);
            Controls.Add(textBox1);
            Controls.Add(txtMSSV);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "bai_so_2";
            Text = "Đăng ký môn học";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMSSV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtHoVaTen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtNienKhoa;
        private System.Windows.Forms.ComboBox cboNienKhoa;
        private System.Windows.Forms.Label txtLop;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label txtHocKy;
        private System.Windows.Forms.RadioButton rdoI;
        private System.Windows.Forms.RadioButton rdoII;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label txtMonHoc;
        private System.Windows.Forms.CheckedListBox clbMonHoc;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
    }
}