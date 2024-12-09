namespace BookShopTuto
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            lblSoDonBanRa = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label5 = new Label();
            lblDoanhThuNgay = new Label();
            label4 = new Label();
            panel3 = new Panel();
            cbDoanhThuTheoThang = new ComboBox();
            label6 = new Label();
            lblDoanhThuThang = new Label();
            label8 = new Label();
            panel4 = new Panel();
            label9 = new Label();
            lblSachBanChay = new Label();
            label10 = new Label();
            panel5 = new Panel();
            label11 = new Label();
            lblSachHetHang = new Label();
            label12 = new Label();
            DoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnQuanLy = new Button();
            btnShow = new Button();
            btnUser = new Button();
            btnDangXuat = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoanhThu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(846, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(244, 53);
            label1.TabIndex = 0;
            label1.Text = "Trang Chủ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblSoDonBanRa);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(90, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 166);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 166);
            label3.TabIndex = 2;
            // 
            // lblSoDonBanRa
            // 
            lblSoDonBanRa.AutoSize = true;
            lblSoDonBanRa.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoDonBanRa.ForeColor = SystemColors.Control;
            lblSoDonBanRa.Location = new Point(107, 88);
            lblSoDonBanRa.Name = "lblSoDonBanRa";
            lblSoDonBanRa.Size = new Size(40, 45);
            lblSoDonBanRa.TabIndex = 1;
            lblSoDonBanRa.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(107, 32);
            label2.Name = "label2";
            label2.Size = new Size(389, 38);
            label2.TabIndex = 0;
            label2.Text = "Số đơn bán ra trong ngày";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblDoanhThuNgay);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(720, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(505, 166);
            panel2.TabIndex = 2;
            // 
            // label7
            // 
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 166);
            label7.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(337, 88);
            label5.Name = "label5";
            label5.Size = new Size(0, 45);
            label5.TabIndex = 2;
            // 
            // lblDoanhThuNgay
            // 
            lblDoanhThuNgay.AutoSize = true;
            lblDoanhThuNgay.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoanhThuNgay.ForeColor = SystemColors.Control;
            lblDoanhThuNgay.Location = new Point(107, 88);
            lblDoanhThuNgay.Name = "lblDoanhThuNgay";
            lblDoanhThuNgay.Size = new Size(136, 45);
            lblDoanhThuNgay.TabIndex = 1;
            lblDoanhThuNgay.Text = "0 VNĐ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(107, 32);
            label4.Name = "label4";
            label4.Size = new Size(337, 38);
            label4.TabIndex = 0;
            label4.Text = "Doanh thu trong ngày";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Orange;
            panel3.Controls.Add(cbDoanhThuTheoThang);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lblDoanhThuThang);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(1346, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(505, 166);
            panel3.TabIndex = 3;
            // 
            // cbDoanhThuTheoThang
            // 
            cbDoanhThuTheoThang.FormattingEnabled = true;
            cbDoanhThuTheoThang.Location = new Point(364, 27);
            cbDoanhThuTheoThang.Name = "cbDoanhThuTheoThang";
            cbDoanhThuTheoThang.Size = new Size(120, 30);
            cbDoanhThuTheoThang.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(337, 88);
            label6.Name = "label6";
            label6.Size = new Size(0, 45);
            label6.TabIndex = 2;
            // 
            // lblDoanhThuThang
            // 
            lblDoanhThuThang.AutoSize = true;
            lblDoanhThuThang.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoanhThuThang.ForeColor = SystemColors.Control;
            lblDoanhThuThang.Location = new Point(32, 88);
            lblDoanhThuThang.Name = "lblDoanhThuThang";
            lblDoanhThuThang.Size = new Size(136, 45);
            lblDoanhThuThang.TabIndex = 1;
            lblDoanhThuThang.Text = "0 VNĐ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(23, 24);
            label8.Name = "label8";
            label8.Size = new Size(335, 38);
            label8.TabIndex = 0;
            label8.Text = "Doanh thu theo tháng";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Orange;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(lblSachBanChay);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(90, 285);
            panel4.Name = "panel4";
            panel4.Size = new Size(505, 166);
            panel4.TabIndex = 2;
            // 
            // label9
            // 
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(98, 166);
            label9.TabIndex = 4;
            // 
            // lblSachBanChay
            // 
            lblSachBanChay.AutoSize = true;
            lblSachBanChay.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSachBanChay.ForeColor = SystemColors.Control;
            lblSachBanChay.Location = new Point(107, 88);
            lblSachBanChay.Name = "lblSachBanChay";
            lblSachBanChay.Size = new Size(40, 45);
            lblSachBanChay.TabIndex = 1;
            lblSachBanChay.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(107, 32);
            label10.Name = "label10";
            label10.Size = new Size(394, 38);
            label10.TabIndex = 0;
            label10.Text = "Sách bán chạy nhất tháng";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Orange;
            panel5.Controls.Add(label11);
            panel5.Controls.Add(lblSachHetHang);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(720, 285);
            panel5.Name = "panel5";
            panel5.Size = new Size(505, 166);
            panel5.TabIndex = 3;
            // 
            // label11
            // 
            label11.Image = (Image)resources.GetObject("label11.Image");
            label11.Location = new Point(10, 0);
            label11.Name = "label11";
            label11.Size = new Size(98, 166);
            label11.TabIndex = 5;
            // 
            // lblSachHetHang
            // 
            lblSachHetHang.AutoSize = true;
            lblSachHetHang.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSachHetHang.ForeColor = SystemColors.Control;
            lblSachHetHang.Location = new Point(115, 88);
            lblSachHetHang.Name = "lblSachHetHang";
            lblSachHetHang.Size = new Size(40, 45);
            lblSachHetHang.TabIndex = 1;
            lblSachHetHang.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(115, 32);
            label12.Name = "label12";
            label12.Size = new Size(280, 38);
            label12.TabIndex = 0;
            label12.Text = "Sách sắp hết hàng";
            // 
            // DoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            DoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            DoanhThu.Legends.Add(legend1);
            DoanhThu.Location = new Point(90, 478);
            DoanhThu.Name = "DoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            DoanhThu.Series.Add(series1);
            DoanhThu.Size = new Size(1744, 487);
            DoanhThu.TabIndex = 4;
            DoanhThu.Text = "DoanhThu";
            // 
            // btnQuanLy
            // 
            btnQuanLy.BackColor = Color.Orange;
            btnQuanLy.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuanLy.ForeColor = SystemColors.Control;
            btnQuanLy.Location = new Point(1346, 285);
            btnQuanLy.Name = "btnQuanLy";
            btnQuanLy.Size = new Size(200, 70);
            btnQuanLy.TabIndex = 5;
            btnQuanLy.Text = "Quản lý";
            btnQuanLy.UseVisualStyleBackColor = false;
            btnQuanLy.Click += btnQuanLy_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Orange;
            btnShow.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.ForeColor = SystemColors.Control;
            btnShow.Location = new Point(1346, 381);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(200, 70);
            btnShow.TabIndex = 6;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click_1;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.Orange;
            btnUser.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = SystemColors.Control;
            btnUser.Location = new Point(1651, 285);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(200, 70);
            btnUser.TabIndex = 7;
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Orange;
            btnDangXuat.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = SystemColors.Control;
            btnDangXuat.Location = new Point(1651, 381);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(200, 70);
            btnDangXuat.TabIndex = 8;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnDangXuat);
            Controls.Add(btnUser);
            Controls.Add(btnShow);
            Controls.Add(btnQuanLy);
            Controls.Add(DoanhThu);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang Chủ";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoanhThu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label lblSoDonBanRa;
        private Panel panel2;
        private Label label5;
        private Label lblDoanhThuNgay;
        private Label label4;
        private Panel panel3;
        private Label label6;
        private Label lblDoanhThuThang;
        private Label label8;
        private ComboBox cbDoanhThuTheoThang;
        private Panel panel4;
        private Label lblSachBanChay;
        private Label label10;
        private Panel panel5;
        private Label lblSachHetHang;
        private Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart DoanhThu;
        private Button btnQuanLy;
        private Button btnShow;
        private Label label3;
        private Label label7;
        private Label label9;
        private Label label11;
        private Button btnUser;
        private Button btnDangXuat;
    }
}