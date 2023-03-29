namespace GUI_QLHSApp
{
    partial class frmGiaoVien
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
            txtMaGV = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtHoGV = new TextBox();
            txtTenGV = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtQueQuanGV = new TextBox();
            txtSODTGV = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dgvGiaoVien = new DataGridView();
            btnThemGV = new Button();
            btnSuaGV = new Button();
            btnXoaGV = new Button();
            txtTimGV = new TextBox();
            label8 = new Label();
            rdMa = new RadioButton();
            rdTen = new RadioButton();
            groupBox1 = new GroupBox();
            dtpNgaySinhGV = new DateTimePicker();
            btnThoat = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGiaoVien).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaGV
            // 
            txtMaGV.Location = new Point(142, 46);
            txtMaGV.Name = "txtMaGV";
            txtMaGV.Size = new Size(254, 27);
            txtMaGV.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(16, 47);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 3;
            label2.Text = "Mã Giáo Viên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(431, 47);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 4;
            label3.Text = "Họ :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHoGV
            // 
            txtHoGV.Location = new Point(520, 45);
            txtHoGV.Name = "txtHoGV";
            txtHoGV.Size = new Size(259, 27);
            txtHoGV.TabIndex = 5;
            // 
            // txtTenGV
            // 
            txtTenGV.Location = new Point(879, 49);
            txtTenGV.Name = "txtTenGV";
            txtTenGV.Size = new Size(260, 27);
            txtTenGV.TabIndex = 2;
            // 
            // label4
            // 
            label4.Location = new Point(785, 49);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "Tên :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(16, 123);
            label5.Name = "label5";
            label5.Size = new Size(120, 25);
            label5.TabIndex = 3;
            label5.Text = "Ngày Sinh :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtQueQuanGV
            // 
            txtQueQuanGV.Location = new Point(519, 121);
            txtQueQuanGV.Name = "txtQueQuanGV";
            txtQueQuanGV.Size = new Size(260, 27);
            txtQueQuanGV.TabIndex = 7;
            // 
            // txtSODTGV
            // 
            txtSODTGV.Location = new Point(879, 122);
            txtSODTGV.Name = "txtSODTGV";
            txtSODTGV.Size = new Size(260, 27);
            txtSODTGV.TabIndex = 7;
            // 
            // label6
            // 
            label6.Location = new Point(431, 123);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 8;
            label6.Text = "Quê Quán :";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Location = new Point(785, 125);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 9;
            label7.Text = "Điện Thoại :";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvGiaoVien
            // 
            dgvGiaoVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGiaoVien.Location = new Point(18, 326);
            dgvGiaoVien.Name = "dgvGiaoVien";
            dgvGiaoVien.RowHeadersWidth = 51;
            dgvGiaoVien.RowTemplate.Height = 29;
            dgvGiaoVien.Size = new Size(1164, 401);
            dgvGiaoVien.TabIndex = 10;
            // 
            // btnThemGV
            // 
            btnThemGV.Location = new Point(722, 243);
            btnThemGV.Name = "btnThemGV";
            btnThemGV.Size = new Size(94, 61);
            btnThemGV.TabIndex = 11;
            btnThemGV.Text = "Thêm Giáo Viên";
            btnThemGV.UseVisualStyleBackColor = true;
            // 
            // btnSuaGV
            // 
            btnSuaGV.Location = new Point(950, 243);
            btnSuaGV.Name = "btnSuaGV";
            btnSuaGV.Size = new Size(94, 61);
            btnSuaGV.TabIndex = 12;
            btnSuaGV.Text = "Sửa Thông Tin";
            btnSuaGV.UseVisualStyleBackColor = true;
            // 
            // btnXoaGV
            // 
            btnXoaGV.Location = new Point(834, 243);
            btnXoaGV.Name = "btnXoaGV";
            btnXoaGV.Size = new Size(94, 61);
            btnXoaGV.TabIndex = 13;
            btnXoaGV.Text = "Xóa Giáo Viên";
            btnXoaGV.UseVisualStyleBackColor = true;
            // 
            // txtTimGV
            // 
            txtTimGV.Location = new Point(97, 272);
            txtTimGV.Name = "txtTimGV";
            txtTimGV.Size = new Size(254, 27);
            txtTimGV.TabIndex = 14;
            // 
            // label8
            // 
            label8.Location = new Point(12, 243);
            label8.Name = "label8";
            label8.Size = new Size(55, 25);
            label8.TabIndex = 3;
            label8.Text = "Tìm :";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rdMa
            // 
            rdMa.AutoSize = true;
            rdMa.Location = new Point(97, 242);
            rdMa.Name = "rdMa";
            rdMa.Size = new Size(51, 24);
            rdMa.TabIndex = 15;
            rdMa.TabStop = true;
            rdMa.Text = "Mã";
            rdMa.UseVisualStyleBackColor = true;
            // 
            // rdTen
            // 
            rdTen.AutoSize = true;
            rdTen.Location = new Point(250, 243);
            rdTen.Name = "rdTen";
            rdTen.Size = new Size(53, 24);
            rdTen.TabIndex = 16;
            rdTen.TabStop = true;
            rdTen.Text = "Tên";
            rdTen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgaySinhGV);
            groupBox1.Controls.Add(txtQueQuanGV);
            groupBox1.Controls.Add(txtMaGV);
            groupBox1.Controls.Add(txtTenGV);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHoGV);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSODTGV);
            groupBox1.Location = new Point(18, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1164, 210);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Giáo Viên";
            // 
            // dtpNgaySinhGV
            // 
            dtpNgaySinhGV.Location = new Point(142, 120);
            dtpNgaySinhGV.Name = "dtpNgaySinhGV";
            dtpNgaySinhGV.Size = new Size(250, 27);
            dtpNgaySinhGV.TabIndex = 10;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1063, 243);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 61);
            btnThoat.TabIndex = 18;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // button1
            // 
            button1.Location = new Point(382, 272);
            button1.Name = "button1";
            button1.Size = new Size(67, 32);
            button1.TabIndex = 19;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmGiaoVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 743);
            Controls.Add(button1);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Controls.Add(rdTen);
            Controls.Add(rdMa);
            Controls.Add(txtTimGV);
            Controls.Add(btnXoaGV);
            Controls.Add(btnSuaGV);
            Controls.Add(btnThemGV);
            Controls.Add(dgvGiaoVien);
            Controls.Add(label8);
            Name = "frmGiaoVien";
            Text = "Giáo Viên";
            Load += frmGiaoVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGiaoVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox txtMaGV;
        private Label label2;
        private Label label3;
        private TextBox txtHoGV;
        private TextBox txtTenGV;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;

        public DateTimePicker DTPNgaySinhGV { get; private set; }

        private TextBox txtQueQuanGV;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private TextBox txtSODTGV;
        private Label label6;
        private Label label7;
        private DataGridView dgvGiaoVien;
        private Button btnThemGV;
        private Button btnSuaGV;
        private Button btnXoaGV;
        private TextBox txtTimGV;
        private Label label8;
        private RadioButton rdMa;
        private RadioButton rdTen;
        private GroupBox groupBox1;
        private Button btnThoat;
        private DateTimePicker dtpNgaySinhGV;
        private Button button1;
    }
}