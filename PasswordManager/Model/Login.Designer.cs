namespace PasswordManager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            txtUser = new TextBox();
            textBox2 = new TextBox();
            txtPassword = new TextBox();
            textBox4 = new TextBox();
            btnLogin = new Button();
            linkRegister = new LinkLabel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(450, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(15, 15, 15);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = SystemColors.ActiveBorder;
            txtUser.Location = new Point(37, 136);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuario";
            txtUser.Size = new Size(210, 25);
            txtUser.TabIndex = 1;
            txtUser.Enter += txtUser_Enter;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(15, 15, 15);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ActiveBorder;
            textBox2.Location = new Point(37, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(376, 25);
            textBox2.TabIndex = 2;
            textBox2.Text = "_________________________________________";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.ActiveBorder;
            txtPassword.Location = new Point(37, 234);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(210, 25);
            txtPassword.TabIndex = 3;
            txtPassword.Enter += txtPassword_Enter;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(15, 15, 15);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = SystemColors.ActiveBorder;
            textBox4.Location = new Point(37, 247);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(376, 25);
            textBox4.TabIndex = 4;
            textBox4.Text = "_________________________________________";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 122, 204);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(137, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(149, 40);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkRegister
            // 
            linkRegister.ActiveLinkColor = Color.DarkGray;
            linkRegister.AutoSize = true;
            linkRegister.LinkColor = Color.FromArgb(0, 122, 204);
            linkRegister.Location = new Point(273, 382);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(76, 20);
            linkRegister.TabIndex = 8;
            linkRegister.TabStop = true;
            linkRegister.Text = "Registrate";
            linkRegister.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(87, 382);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 9;
            label1.Text = "¿Aún no tienes una cuenta?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(185, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(linkRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(textBox4);
            Controls.Add(txtUser);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUser;
        private TextBox textBox2;
        private TextBox txtPassword;
        private TextBox textBox4;
        private Button btnLogin;
        private LinkLabel linkRegister;
        private Label label1;
        private PictureBox pictureBox1;
    }
}