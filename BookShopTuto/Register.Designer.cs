namespace BookShopTuto
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            txtXacNhanMatKhau = new TextBox();
            btnLogin = new Button();
            label8 = new Label();
            btnRegister = new Button();
            label3 = new Label();
            label2 = new Label();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 426);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label4.ForeColor = SystemColors.MenuText;
            label4.Location = new Point(19, 290);
            label4.Name = "label4";
            label4.Size = new Size(174, 45);
            label4.TabIndex = 5;
            label4.Text = "Đếm tiền";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 16.2F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(19, 223);
            label7.Name = "label7";
            label7.Size = new Size(120, 33);
            label7.TabIndex = 4;
            label7.Text = "Ngày mai";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            label6.ForeColor = SystemColors.MenuText;
            label6.Location = new Point(19, 145);
            label6.Name = "label6";
            label6.Size = new Size(165, 45);
            label6.TabIndex = 3;
            label6.Text = "Lật sách";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(19, 80);
            label5.Name = "label5";
            label5.Size = new Size(114, 33);
            label5.TabIndex = 2;
            label5.Text = "Hôm nay";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtXacNhanMatKhau);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtMatKhau);
            panel2.Controls.Add(txtTaiKhoan);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(263, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(598, 426);
            panel2.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(53, 312);
            label9.Name = "label9";
            label9.Size = new Size(181, 25);
            label9.TabIndex = 12;
            label9.Text = "Xác nhận mật khẩu";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtXacNhanMatKhau.Location = new Point(258, 305);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(307, 32);
            txtXacNhanMatKhau.TabIndex = 11;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Orange;
            btnLogin.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(438, 355);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(127, 40);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(553, 9);
            label8.Name = "label8";
            label8.Size = new Size(31, 29);
            label8.TabIndex = 9;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Orange;
            btnRegister.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(258, 355);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(127, 40);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(53, 263);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 6;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(53, 212);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 5;
            label2.Text = "Tài khoản";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(258, 255);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(307, 32);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaiKhoan.Location = new Point(258, 205);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(307, 32);
            txtTaiKhoan.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(238, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(133, 15);
            label1.Name = "label1";
            label1.Size = new Size(343, 40);
            label1.TabIndex = 1;
            label1.Text = "Cửa hàng bán sách";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(873, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel2;
        private Button btnLogin;
        private Label label8;
        private Button btnRegister;
        private Label label3;
        private Label label2;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label9;
        private TextBox txtXacNhanMatKhau;
    }
}