namespace BookShopTuto
{
    partial class KhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoHang));
            txtSearch = new TextBox();
            label11 = new Label();
            dgKhoHang = new DataGridView();
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
            label8 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgKhoHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(26, 163);
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
            label11.Location = new Point(26, 132);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(91, 25);
            label11.TabIndex = 30;
            label11.Text = "Tìm kiếm";
            // 
            // dgKhoHang
            // 
            dgKhoHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgKhoHang.BackgroundColor = Color.White;
            dgKhoHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKhoHang.Location = new Point(26, 218);
            dgKhoHang.Margin = new Padding(4, 5, 4, 5);
            dgKhoHang.Name = "dgKhoHang";
            dgKhoHang.RowHeadersWidth = 51;
            dgKhoHang.Size = new Size(1435, 729);
            dgKhoHang.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(498, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(476, 56);
            label1.TabIndex = 1;
            label1.Text = "Cửa hàng bán sách";
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlDark;
            button8.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(19, 758);
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
            button7.BackColor = Color.Orange;
            button7.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(19, 646);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(362, 63);
            button7.TabIndex = 4;
            button7.Text = "Kho hàng";
            button7.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 534);
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
            button5.Location = new Point(19, 869);
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
            button4.Location = new Point(19, 422);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(362, 63);
            button4.TabIndex = 2;
            button4.Text = "Hóa đơn";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(19, 311);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(362, 63);
            button3.TabIndex = 1;
            button3.Text = "Loại Sách";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            pictureBox1.Margin = new Padding(4);
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
            panel1.Location = new Point(16, 13);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 964);
            panel1.TabIndex = 4;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dgKhoHang);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(420, 14);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1480, 964);
            panel2.TabIndex = 5;
            // 
            // KhoHang
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(1764, 1055);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "KhoHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Kho Hàng";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgKhoHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSearch;
        private Label label11;
        private DataGridView dgKhoHang;
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
        private Label label8;
        private Panel panel2;
    }
}