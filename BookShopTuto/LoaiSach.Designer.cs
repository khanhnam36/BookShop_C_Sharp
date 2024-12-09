namespace BookShopTuto
{
    partial class LoaiSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiSach));
            btnLoaiSachXóa = new Button();
            btnLoaiSachThem = new Button();
            dgLoaiSach = new DataGridView();
            btnLoaiSachSua = new Button();
            panel2 = new Panel();
            txtSearch = new TextBox();
            label11 = new Label();
            panel3 = new Panel();
            btnLoaiSachRefresh = new Button();
            txtLoaiSachTen = new TextBox();
            label2 = new Label();
            label8 = new Label();
            label1 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button1 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgLoaiSach).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoaiSachXóa
            // 
            btnLoaiSachXóa.BackColor = Color.Orange;
            btnLoaiSachXóa.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnLoaiSachXóa.ForeColor = Color.White;
            btnLoaiSachXóa.Location = new Point(615, 75);
            btnLoaiSachXóa.Margin = new Padding(4, 3, 4, 3);
            btnLoaiSachXóa.Name = "btnLoaiSachXóa";
            btnLoaiSachXóa.Size = new Size(175, 44);
            btnLoaiSachXóa.TabIndex = 3;
            btnLoaiSachXóa.Text = "Xóa";
            btnLoaiSachXóa.UseVisualStyleBackColor = false;
            btnLoaiSachXóa.Click += btnLoaiSachXóa_Click;
            // 
            // btnLoaiSachThem
            // 
            btnLoaiSachThem.BackColor = Color.Orange;
            btnLoaiSachThem.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnLoaiSachThem.ForeColor = Color.White;
            btnLoaiSachThem.Location = new Point(144, 75);
            btnLoaiSachThem.Margin = new Padding(4, 3, 4, 3);
            btnLoaiSachThem.Name = "btnLoaiSachThem";
            btnLoaiSachThem.Size = new Size(175, 44);
            btnLoaiSachThem.TabIndex = 1;
            btnLoaiSachThem.Text = "Thêm";
            btnLoaiSachThem.UseVisualStyleBackColor = false;
            btnLoaiSachThem.Click += btnLoaiSachThem_Click_1;
            // 
            // dgLoaiSach
            // 
            dgLoaiSach.BackgroundColor = Color.White;
            dgLoaiSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLoaiSach.Location = new Point(26, 376);
            dgLoaiSach.Margin = new Padding(4, 5, 4, 5);
            dgLoaiSach.Name = "dgLoaiSach";
            dgLoaiSach.RowHeadersWidth = 51;
            dgLoaiSach.Size = new Size(1435, 571);
            dgLoaiSach.TabIndex = 1;
            dgLoaiSach.CellClick += dgLoaiSach_CellClick_1;
            // 
            // btnLoaiSachSua
            // 
            btnLoaiSachSua.BackColor = Color.Orange;
            btnLoaiSachSua.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnLoaiSachSua.ForeColor = Color.White;
            btnLoaiSachSua.Location = new Point(378, 75);
            btnLoaiSachSua.Margin = new Padding(4, 3, 4, 3);
            btnLoaiSachSua.Name = "btnLoaiSachSua";
            btnLoaiSachSua.Size = new Size(175, 44);
            btnLoaiSachSua.TabIndex = 2;
            btnLoaiSachSua.Text = "Sửa";
            btnLoaiSachSua.UseVisualStyleBackColor = false;
            btnLoaiSachSua.Click += btnLoaiSachSua_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgLoaiSach);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(419, 13);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1480, 964);
            panel2.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(26, 322);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1435, 30);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(26, 292);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(91, 25);
            label11.TabIndex = 30;
            label11.Text = "Tìm kiếm";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLoaiSachRefresh);
            panel3.Controls.Add(btnLoaiSachXóa);
            panel3.Controls.Add(txtLoaiSachTen);
            panel3.Controls.Add(btnLoaiSachSua);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnLoaiSachThem);
            panel3.Location = new Point(26, 135);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1504, 138);
            panel3.TabIndex = 23;
            // 
            // btnLoaiSachRefresh
            // 
            btnLoaiSachRefresh.BackColor = Color.Orange;
            btnLoaiSachRefresh.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            btnLoaiSachRefresh.ForeColor = Color.White;
            btnLoaiSachRefresh.Location = new Point(848, 75);
            btnLoaiSachRefresh.Margin = new Padding(4, 3, 4, 3);
            btnLoaiSachRefresh.Name = "btnLoaiSachRefresh";
            btnLoaiSachRefresh.Size = new Size(175, 44);
            btnLoaiSachRefresh.TabIndex = 4;
            btnLoaiSachRefresh.Text = "Refresh";
            btnLoaiSachRefresh.UseVisualStyleBackColor = false;
            btnLoaiSachRefresh.Click += btnLoaiSachRefresh_Click;
            // 
            // txtLoaiSachTen
            // 
            txtLoaiSachTen.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoaiSachTen.Location = new Point(209, 18);
            txtLoaiSachTen.Margin = new Padding(4, 3, 4, 3);
            txtLoaiSachTen.Name = "txtLoaiSachTen";
            txtLoaiSachTen.Size = new Size(498, 34);
            txtLoaiSachTen.TabIndex = 0;
            txtLoaiSachTen.TextChanged += txtSachTenSach_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(23, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 5;
            label2.Text = "Tên loại sách";
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
            label8.Click += label8_Click;
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
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
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
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(16, 13);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 964);
            panel1.TabIndex = 4;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlDark;
            button8.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(18, 762);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new Size(362, 63);
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
            button7.Location = new Point(18, 649);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(362, 63);
            button7.TabIndex = 4;
            button7.Text = "Kho hàng";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(18, 536);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(362, 63);
            button1.TabIndex = 3;
            button1.Text = "Phiếu nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlDark;
            button5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(18, 875);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(362, 63);
            button5.TabIndex = 6;
            button5.Text = "Thoát";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(18, 424);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(362, 63);
            button4.TabIndex = 2;
            button4.Text = "Hóa đơn";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(18, 198);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(362, 63);
            button2.TabIndex = 0;
            button2.Text = "Sách";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(18, 311);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(362, 63);
            button3.TabIndex = 1;
            button3.Text = "Loại sách";
            button3.UseVisualStyleBackColor = false;
            // 
            // LoaiSach
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(1764, 1055);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoaiSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Loại Sách";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgLoaiSach).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoaiSachXóa;
        private Button btnLoaiSachThem;
        private DataGridView dgLoaiSach;
        private Button btnLoaiSachSua;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtLoaiSachTen;
        private Label label2;
        private Label label8;
        private Label label1;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button3;
        private TextBox txtSearch;
        private Label label11;
        private Button button8;
        private Button button7;
        private Button btnLoaiSachRefresh;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}