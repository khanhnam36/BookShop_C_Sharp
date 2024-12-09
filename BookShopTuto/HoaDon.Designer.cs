namespace BookShopTuto
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            button1 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            txtHoaDonSDTKH = new TextBox();
            dateNgayLapHoaDon = new DateTimePicker();
            label2 = new Label();
            label7 = new Label();
            txtHoaDonTenKH = new TextBox();
            dgHoaDon = new DataGridView();
            panel2 = new Panel();
            dgSachDaChon = new DataGridView();
            panel5 = new Panel();
            btnHoaDonRefresh = new Button();
            btnHoaDonXoa = new Button();
            btnHoaDonSua = new Button();
            btnHoaDonThem = new Button();
            label12 = new Label();
            dgChonSach = new DataGridView();
            txtHoaDonSearch = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label4 = new Label();
            label8 = new Label();
            label1 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgHoaDon).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSachDaChon).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgChonSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 537);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(361, 62);
            button1.TabIndex = 3;
            button1.Text = "Phiếu nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtHoaDonSDTKH);
            panel3.Controls.Add(dateNgayLapHoaDon);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtHoaDonTenKH);
            panel3.Location = new Point(26, 128);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(562, 180);
            panel3.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(20, 149);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 24;
            label3.Text = "SDT Khách Hàng";
            // 
            // txtHoaDonSDTKH
            // 
            txtHoaDonSDTKH.Font = new Font("Times New Roman", 12F);
            txtHoaDonSDTKH.Location = new Point(272, 146);
            txtHoaDonSDTKH.Margin = new Padding(4);
            txtHoaDonSDTKH.Name = "txtHoaDonSDTKH";
            txtHoaDonSDTKH.Size = new Size(261, 26);
            txtHoaDonSDTKH.TabIndex = 2;
            // 
            // dateNgayLapHoaDon
            // 
            dateNgayLapHoaDon.Location = new Point(272, 13);
            dateNgayLapHoaDon.Margin = new Padding(4);
            dateNgayLapHoaDon.Name = "dateNgayLapHoaDon";
            dateNgayLapHoaDon.Size = new Size(261, 23);
            dateNgayLapHoaDon.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(19, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 5;
            label2.Text = "Ngày Lập Hóa Đơn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Coral;
            label7.Location = new Point(19, 85);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 13;
            label7.Text = "Tên Khách Hàng";
            // 
            // txtHoaDonTenKH
            // 
            txtHoaDonTenKH.Font = new Font("Times New Roman", 12F);
            txtHoaDonTenKH.Location = new Point(272, 82);
            txtHoaDonTenKH.Margin = new Padding(4);
            txtHoaDonTenKH.Name = "txtHoaDonTenKH";
            txtHoaDonTenKH.Size = new Size(261, 26);
            txtHoaDonTenKH.TabIndex = 1;
            // 
            // dgHoaDon
            // 
            dgHoaDon.BackgroundColor = Color.White;
            dgHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgHoaDon.Location = new Point(26, 490);
            dgHoaDon.Margin = new Padding(4, 5, 4, 5);
            dgHoaDon.Name = "dgHoaDon";
            dgHoaDon.RowHeadersWidth = 51;
            dgHoaDon.Size = new Size(1435, 457);
            dgHoaDon.TabIndex = 1;
            dgHoaDon.CellClick += dgHoaDon_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgSachDaChon);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(dgChonSach);
            panel2.Controls.Add(txtHoaDonSearch);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgHoaDon);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(420, 13);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1480, 964);
            panel2.TabIndex = 5;
            // 
            // dgSachDaChon
            // 
            dgSachDaChon.BackgroundColor = Color.White;
            dgSachDaChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSachDaChon.Location = new Point(1032, 128);
            dgSachDaChon.Name = "dgSachDaChon";
            dgSachDaChon.RowHeadersWidth = 51;
            dgSachDaChon.Size = new Size(436, 176);
            dgSachDaChon.TabIndex = 32;
            dgSachDaChon.CellClick += dgSachDaChon_CellClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnHoaDonRefresh);
            panel5.Controls.Add(btnHoaDonXoa);
            panel5.Controls.Add(btnHoaDonSua);
            panel5.Controls.Add(btnHoaDonThem);
            panel5.Location = new Point(26, 324);
            panel5.Name = "panel5";
            panel5.Size = new Size(892, 77);
            panel5.TabIndex = 31;
            // 
            // btnHoaDonRefresh
            // 
            btnHoaDonRefresh.BackColor = Color.Orange;
            btnHoaDonRefresh.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnHoaDonRefresh.ForeColor = Color.White;
            btnHoaDonRefresh.Location = new Point(637, 16);
            btnHoaDonRefresh.Margin = new Padding(4);
            btnHoaDonRefresh.Name = "btnHoaDonRefresh";
            btnHoaDonRefresh.Size = new Size(130, 44);
            btnHoaDonRefresh.TabIndex = 9;
            btnHoaDonRefresh.Text = "Refresh";
            btnHoaDonRefresh.UseVisualStyleBackColor = false;
            btnHoaDonRefresh.Click += btnHoaDonRefresh_Click;
            // 
            // btnHoaDonXoa
            // 
            btnHoaDonXoa.BackColor = Color.Orange;
            btnHoaDonXoa.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnHoaDonXoa.ForeColor = Color.White;
            btnHoaDonXoa.Location = new Point(462, 16);
            btnHoaDonXoa.Margin = new Padding(4);
            btnHoaDonXoa.Name = "btnHoaDonXoa";
            btnHoaDonXoa.Size = new Size(130, 44);
            btnHoaDonXoa.TabIndex = 8;
            btnHoaDonXoa.Text = "Xóa";
            btnHoaDonXoa.UseVisualStyleBackColor = false;
            btnHoaDonXoa.Click += btnHoaDonXoa_Click;
            // 
            // btnHoaDonSua
            // 
            btnHoaDonSua.BackColor = Color.Orange;
            btnHoaDonSua.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnHoaDonSua.ForeColor = Color.White;
            btnHoaDonSua.Location = new Point(293, 16);
            btnHoaDonSua.Margin = new Padding(4);
            btnHoaDonSua.Name = "btnHoaDonSua";
            btnHoaDonSua.Size = new Size(130, 44);
            btnHoaDonSua.TabIndex = 7;
            btnHoaDonSua.Text = "Sửa";
            btnHoaDonSua.UseVisualStyleBackColor = false;
            btnHoaDonSua.Click += btnHoaDonSua_Click;
            // 
            // btnHoaDonThem
            // 
            btnHoaDonThem.BackColor = Color.Orange;
            btnHoaDonThem.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnHoaDonThem.ForeColor = Color.White;
            btnHoaDonThem.Location = new Point(126, 16);
            btnHoaDonThem.Margin = new Padding(4);
            btnHoaDonThem.Name = "btnHoaDonThem";
            btnHoaDonThem.Size = new Size(130, 44);
            btnHoaDonThem.TabIndex = 6;
            btnHoaDonThem.Text = "Thêm";
            btnHoaDonThem.UseVisualStyleBackColor = false;
            btnHoaDonThem.Click += btnHoaDonThem_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(618, 98);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 30;
            label12.Text = "Chọn sách";
            // 
            // dgChonSach
            // 
            dgChonSach.BackgroundColor = Color.White;
            dgChonSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgChonSach.Location = new Point(618, 128);
            dgChonSach.Name = "dgChonSach";
            dgChonSach.RowHeadersWidth = 51;
            dgChonSach.Size = new Size(364, 176);
            dgChonSach.TabIndex = 29;
            dgChonSach.CellValidating += dgChonSach_CellValidating;
            // 
            // txtHoaDonSearch
            // 
            txtHoaDonSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoaDonSearch.Location = new Point(26, 445);
            txtHoaDonSearch.Margin = new Padding(4, 5, 4, 5);
            txtHoaDonSearch.Name = "txtHoaDonSearch";
            txtHoaDonSearch.Size = new Size(1435, 26);
            txtHoaDonSearch.TabIndex = 0;
            txtHoaDonSearch.TextChanged += txtHoaDonSearch_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(26, 415);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 28;
            label11.Text = "Tìm kiếm";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(1032, 98);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(107, 20);
            label10.TabIndex = 27;
            label10.Text = "Sách đã chọn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(26, 98);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 26;
            label4.Text = "Thông tin khách hàng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(1504, 18);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(27, 25);
            label8.TabIndex = 9;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(499, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(331, 43);
            label1.TabIndex = 1;
            label1.Text = "Cửa hàng bán sách";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(184, 52);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(157, 72);
            label5.TabIndex = 3;
            label5.Text = "Cửa hàng \r\nbán sách";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 17);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlDark;
            button5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(19, 876);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(361, 62);
            button5.TabIndex = 6;
            button5.Text = "Thoát";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Orange;
            button4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(19, 424);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(361, 62);
            button4.TabIndex = 2;
            button4.Text = "Hóa đơn";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(19, 312);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(361, 62);
            button3.TabIndex = 1;
            button3.Text = "Loại sách";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(19, 199);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(361, 62);
            button2.TabIndex = 0;
            button2.Text = "Sách";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(16, 13);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 964);
            panel1.TabIndex = 4;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlDark;
            button8.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(19, 763);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(361, 62);
            button8.TabIndex = 5;
            button8.Text = "Nhà phân phối";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlDark;
            button7.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(19, 650);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(361, 62);
            button7.TabIndex = 4;
            button7.Text = "Kho hàng";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(1764, 1055);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "HoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Hóa Đơn";
            WindowState = FormWindowState.Maximized;
            Load += HoaDon_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgHoaDon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgSachDaChon).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgChonSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel3;
        private Label label2;
        private Label label7;
        private NumericUpDown numSachGiaBan;
        private TextBox txtHoaDonTenKH;
        private NumericUpDown numSachSoLuong;
        private DataGridView dgHoaDon;
        private Panel panel2;
        private Label label8;
        private Label label1;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private DateTimePicker dateNgayLapHoaDon;
        private Label label3;
        private TextBox txtHoaDonSDTKH;
        private Label label10;
        private Label label4;
        private TextBox txtHoaDonSearch;
        private Label label11;
        private Button button8;
        private Button button7;
        private Label label12;
        private DataGridView dgChonSach;
        private Panel panel5;
        private Button btnHoaDonRefresh;
        private Button btnHoaDonXoa;
        private Button btnHoaDonSua;
        private Button btnHoaDonThem;
        private DataGridView dgSachDaChon;
    }
}