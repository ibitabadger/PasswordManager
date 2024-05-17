namespace PasswordManager
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
            button1 = new Button();
            txtPassword0 = new TextBox();
            textBox4 = new TextBox();
            txtUser0 = new TextBox();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 450);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 122, 204);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(508, 380);
            button1.Name = "button1";
            button1.Size = new Size(149, 40);
            button1.TabIndex = 14;
            button1.Text = "Registrate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPassword0
            // 
            txtPassword0.BackColor = Color.FromArgb(15, 15, 15);
            txtPassword0.BorderStyle = BorderStyle.None;
            txtPassword0.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword0.ForeColor = SystemColors.ActiveBorder;
            txtPassword0.Location = new Point(393, 292);
            txtPassword0.Name = "txtPassword0";
            txtPassword0.Size = new Size(210, 25);
            txtPassword0.TabIndex = 12;
            txtPassword0.Text = "Contraseña";
            txtPassword0.Enter += txtPassword0_Enter;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(15, 15, 15);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = SystemColors.ActiveBorder;
            textBox4.Location = new Point(393, 305);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(376, 25);
            textBox4.TabIndex = 13;
            textBox4.Text = "_________________________________________";
            // 
            // txtUser0
            // 
            txtUser0.BackColor = Color.FromArgb(15, 15, 15);
            txtUser0.BorderStyle = BorderStyle.None;
            txtUser0.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser0.ForeColor = SystemColors.ActiveBorder;
            txtUser0.Location = new Point(393, 226);
            txtUser0.Name = "txtUser0";
            txtUser0.Size = new Size(210, 25);
            txtUser0.TabIndex = 10;
            txtUser0.Text = "Usuario";
            txtUser0.Enter += txtUser0_Enter;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(15, 15, 15);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ActiveBorder;
            textBox2.Location = new Point(393, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(376, 25);
            textBox2.TabIndex = 11;
            textBox2.Text = "_________________________________________";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(15, 15, 15);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.ForeColor = SystemColors.ActiveBorder;
            textBox6.Location = new Point(393, 165);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(376, 25);
            textBox6.TabIndex = 16;
            textBox6.Text = "_________________________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(268, -27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(539, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(15, 15, 15);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.ActiveBorder;
            txtEmail.Location = new Point(393, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 25);
            txtEmail.TabIndex = 19;
            txtEmail.Text = "Email";
            txtEmail.Enter += txtEmail_Enter;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox6);
            Controls.Add(button1);
            Controls.Add(txtPassword0);
            Controls.Add(textBox4);
            Controls.Add(txtUser0);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Name = "Register";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox txtPassword0;
        private TextBox textBox4;
        private TextBox txtUser0;
        private TextBox textBox2;
        private TextBox textBox6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtEmail;
    }
}