namespace BookShopTuto
{
    partial class NhaPhanPhoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaPhanPhoi));
            dgNPP = new DataGridView();
            btnNPPRefresh = new Button();
            btnNPPXoa = new Button();
            btnNPPSua = new Button();
            btnNPPThem = new Button();
            label6 = new Label();
            label4 = new Label();
            label7 = new Label();
            txtSearch = new TextBox();
            label11 = new Label();
            panel3 = new Panel();
            txtNPPTen = new TextBox();
            txtNPPSDT = new TextBox();
            txtNPPMa = new TextBox();
            label2 = new Label();
            txtNPPDiaChi = new TextBox();
            label8 = new Label();
            label1 = new Label();
            button8 = new Button();
            button7 = new Button();
            button1 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgNPP).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgNPP
            // 
            dgNPP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgNPP.BackgroundColor = Color.White;
            dgNPP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgNPP.Location = new Point(26, 413);
            dgNPP.Margin = new Padding(4, 5, 4, 5);
            dgNPP.Name = "dgNPP";
            dgNPP.RowHeadersWidth = 51;
            dgNPP.Size = new Size(1435, 534);
            dgNPP.TabIndex = 0;
            dgNPP.CellClick += dgNPP_CellClick;
            // 
            // btnNPPRefresh
            // 
            btnNPPRefresh.BackColor = Color.Orange;
            btnNPPRefresh.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnNPPRefresh.ForeColor = Color.White;
            btnNPPRefresh.Location = new Point(895, 133);
            btnNPPRefresh.Margin = new Padding(4, 3, 4, 3);
            btnNPPRefresh.Name = "btnNPPRefresh";
            btnNPPRefresh.Size = new Size(175, 44);
            btnNPPRefresh.TabIndex = 23;
            btnNPPRefresh.Text = "Refresh";
            btnNPPRefresh.UseVisualStyleBackColor = false;
            btnNPPRefresh.Click += btnNPPRefresh_Click;
            // 
            // btnNPPXoa
            // 
            btnNPPXoa.BackColor = Color.Orange;
            btnNPPXoa.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnNPPXoa.ForeColor = Color.White;
            btnNPPXoa.Location = new Point(661, 133);
            btnNPPXoa.Margin = new Padding(4, 3, 4, 3);
            btnNPPXoa.Name = "btnNPPXoa";
            btnNPPXoa.Size = new Size(175, 44);
            btnNPPXoa.TabIndex = 22;
            btnNPPXoa.Text = "Xóa";
            btnNPPXoa.UseVisualStyleBackColor = false;
            btnNPPXoa.Click += btnNPPXoa_Click;
            // 
            // btnNPPSua
            // 
            btnNPPSua.BackColor = Color.Orange;
            btnNPPSua.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnNPPSua.ForeColor = Color.White;
            btnNPPSua.Location = new Point(425, 133);
            btnNPPSua.Margin = new Padding(4, 3, 4, 3);
            btnNPPSua.Name = "btnNPPSua";
            btnNPPSua.Size = new Size(175, 44);
            btnNPPSua.TabIndex = 21;
            btnNPPSua.Text = "Sửa";
            btnNPPSua.UseVisualStyleBackColor = false;
            btnNPPSua.Click += btnNPPSua_Click;
            // 
            // btnNPPThem
            // 
            btnNPPThem.BackColor = Color.Orange;
            btnNPPThem.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnNPPThem.ForeColor = Color.White;
            btnNPPThem.Location = new Point(191, 133);
            btnNPPThem.Margin = new Padding(4, 3, 4, 3);
            btnNPPThem.Name = "btnNPPThem";
            btnNPPThem.Size = new Size(175, 44);
            btnNPPThem.TabIndex = 20;
            btnNPPThem.Text = "Thêm";
            btnNPPThem.UseVisualStyleBackColor = false;
            btnNPPThem.Click += btnNPPThem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Coral;
            label6.Location = new Point(23, 74);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(176, 25);
            label6.TabIndex = 12;
            label6.Text = "Tên nhà phân phối";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(806, 74);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 18;
            label4.Text = "Số điện thoại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Coral;
            label7.Location = new Point(806, 17);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 25);
            label7.TabIndex = 13;
            label7.Text = "Địa chỉ";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(26, 371);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1435, 30);
            txtSearch.TabIndex = 29;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(26, 341);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(91, 25);
            label11.TabIndex = 30;
            label11.Text = "Tìm kiếm";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtNPPTen);
            panel3.Controls.Add(txtNPPSDT);
            panel3.Controls.Add(btnNPPRefresh);
            panel3.Controls.Add(btnNPPXoa);
            panel3.Controls.Add(txtNPPMa);
            panel3.Controls.Add(btnNPPSua);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnNPPThem);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtNPPDiaChi);
            panel3.Location = new Point(26, 135);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1504, 190);
            panel3.TabIndex = 23;
            // 
            // txtNPPTen
            // 
            txtNPPTen.Font = new Font("Times New Roman", 12F);
            txtNPPTen.Location = new Point(307, 67);
            txtNPPTen.Margin = new Padding(4, 3, 4, 3);
            txtNPPTen.Name = "txtNPPTen";
            txtNPPTen.Size = new Size(372, 30);
            txtNPPTen.TabIndex = 25;
            // 
            // txtNPPSDT
            // 
            txtNPPSDT.Font = new Font("Times New Roman", 12F);
            txtNPPSDT.Location = new Point(1022, 67);
            txtNPPSDT.Margin = new Padding(4, 3, 4, 3);
            txtNPPSDT.Name = "txtNPPSDT";
            txtNPPSDT.Size = new Size(264, 30);
            txtNPPSDT.TabIndex = 24;
            // 
            // txtNPPMa
            // 
            txtNPPMa.Font = new Font("Times New Roman", 12F);
            txtNPPMa.Location = new Point(307, 8);
            txtNPPMa.Margin = new Padding(4, 3, 4, 3);
            txtNPPMa.Name = "txtNPPMa";
            txtNPPMa.Size = new Size(372, 30);
            txtNPPMa.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(23, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 5;
            label2.Text = "Mã nhà phân phối";
            // 
            // txtNPPDiaChi
            // 
            txtNPPDiaChi.Font = new Font("Times New Roman", 12F);
            txtNPPDiaChi.Location = new Point(1022, 14);
            txtNPPDiaChi.Margin = new Padding(4, 3, 4, 3);
            txtNPPDiaChi.Name = "txtNPPDiaChi";
            txtNPPDiaChi.Size = new Size(264, 30);
            txtNPPDiaChi.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(1504, 18);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(31, 29);
            label8.TabIndex = 9;
            label8.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(498, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(410, 53);
            label1.TabIndex = 1;
            label1.Text = "Cửa hàng bán sách";
            // 
            // button8
            // 
            button8.BackColor = Color.Orange;
            button8.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(19, 758);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new Size(362, 63);
            button8.TabIndex = 5;
            button8.Text = "Nhà phân phối";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlDark;
            button7.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(19, 646);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(362, 63);
            button7.TabIndex = 4;
            button7.Text = "Kho hàng";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 535);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(362, 63);
            button1.TabIndex = 3;
            button1.Text = "Phiếu nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlDark;
            button5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(19, 869);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(362, 63);
            button5.TabIndex = 6;
            button5.Text = "Thoát";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(19, 422);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(362, 63);
            button4.TabIndex = 2;
            button4.Text = "Hóa đơn";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(19, 310);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(362, 63);
            button3.TabIndex = 1;
            button3.Text = "Loại Sách";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(19, 199);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(362, 63);
            button2.TabIndex = 0;
            button2.Text = "Sách";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(184, 52);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(195, 90);
            label5.TabIndex = 3;
            label5.Text = "Cửa hàng \r\nbán sách";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 17);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            panel1.Location = new Point(16, 14);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 964);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgNPP);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(419, 14);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1480, 964);
            panel2.TabIndex = 5;
            // 
            // NhaPhanPhoi
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(1764, 1055);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "NhaPhanPhoi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Nhà Phân Phối";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgNPP).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgNPP;
        private Button btnNPPRefresh;
        private Button btnNPPXoa;
        private Button btnNPPSua;
        private Button btnNPPThem;
        private ComboBox cbSachLoaiSach;
        private Label label6;
        private Label label4;
        private Label label7;
        private TextBox txtSearch;
        private Label label11;
        private Panel panel3;
        private TextBox txtNPPMa;
        private Label label2;
        private TextBox txtNPPDiaChi;
        private TextBox txtSachTacGia;
        private Label label8;
        private Label label1;
        private Button button8;
        private Button button7;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtNPPSDT;
        private TextBox txtNPPTen;
    }
}