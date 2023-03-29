namespace QLHSApp
{
    partial class frmTrangChu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuItemQLHS = new ToolStripMenuItem();
            menuItemQLLOP = new ToolStripMenuItem();
            menuItemQLMON = new ToolStripMenuItem();
            menuItemQLDIEM = new ToolStripMenuItem();
            menuItemGV = new ToolStripMenuItem();
            menuItemLD = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(-2, 153);
            label1.Name = "label1";
            label1.Size = new Size(854, 127);
            label1.TabIndex = 0;
            label1.Text = "Trang Chủ Quản Lý Học Sinh";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuItemQLHS, menuItemQLLOP, menuItemQLMON, menuItemQLDIEM, menuItemGV, menuItemLD });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(853, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuItemQLHS
            // 
            menuItemQLHS.Name = "menuItemQLHS";
            menuItemQLHS.Size = new Size(138, 24);
            menuItemQLHS.Text = "Quản Lý Học Sinh";
            // 
            // menuItemQLLOP
            // 
            menuItemQLLOP.Name = "menuItemQLLOP";
            menuItemQLLOP.Size = new Size(104, 24);
            menuItemQLLOP.Text = "Quản Lý Lớp";
            menuItemQLLOP.Click += menuItemQLLOP_Click;
            // 
            // menuItemQLMON
            // 
            menuItemQLMON.Name = "menuItemQLMON";
            menuItemQLMON.Size = new Size(109, 24);
            menuItemQLMON.Text = "Quản Lý Môn";
            // 
            // menuItemQLDIEM
            // 
            menuItemQLDIEM.Name = "menuItemQLDIEM";
            menuItemQLDIEM.Size = new Size(115, 24);
            menuItemQLDIEM.Text = "Quản Lý Điểm";
            // 
            // menuItemGV
            // 
            menuItemGV.Name = "menuItemGV";
            menuItemGV.Size = new Size(87, 24);
            menuItemGV.Text = "Giáo Viên";
            menuItemGV.Click += menuItemGV_Click;
            // 
            // menuItemLD
            // 
            menuItemLD.Name = "menuItemLD";
            menuItemLD.Size = new Size(91, 24);
            menuItemLD.Text = "Loại Điểm";
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(853, 485);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmTrangChu";
            Text = "Quản Lý Học Sinh";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuItemQLHS;
        private ToolStripMenuItem menuItemQLLOP;
        private ToolStripMenuItem menuItemQLMON;
        private ToolStripMenuItem menuItemGV;
        private ToolStripMenuItem menuItemQLDIEM;
        private ToolStripMenuItem menuItemLD;
    }
}