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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 338);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 122, 204);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(444, 285);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(130, 30);
            button1.TabIndex = 14;
            button1.Text = "Registrate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPassword0
            // 
            txtPassword0.BackColor = Color.FromArgb(15, 15, 15);
            txtPassword0.BorderStyle = BorderStyle.None;
            txtPassword0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword0.ForeColor = SystemColors.ActiveBorder;
            txtPassword0.Location = new Point(344, 219);
            txtPassword0.Margin = new Padding(3, 2, 3, 2);
            txtPassword0.Name = "txtPassword0";
            txtPassword0.PlaceholderText = "Contraseña";
            txtPassword0.Size = new Size(329, 19);
            txtPassword0.TabIndex = 12;
            txtPassword0.Enter += txtPassword0_Enter;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(15, 15, 15);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Enabled = false;
            textBox4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = SystemColors.ActiveBorder;
            textBox4.Location = new Point(344, 229);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.ShortcutsEnabled = false;
            textBox4.Size = new Size(329, 19);
            textBox4.TabIndex = 13;
            textBox4.Text = "_________________________________________";
            // 
            // txtUser0
            // 
            txtUser0.BackColor = Color.FromArgb(15, 15, 15);
            txtUser0.BorderStyle = BorderStyle.None;
            txtUser0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser0.ForeColor = SystemColors.ActiveBorder;
            txtUser0.Location = new Point(344, 170);
            txtUser0.Margin = new Padding(3, 2, 3, 2);
            txtUser0.Name = "txtUser0";
            txtUser0.PlaceholderText = "Usuario";
            txtUser0.Size = new Size(329, 19);
            txtUser0.TabIndex = 10;
            txtUser0.Enter += txtUser0_Enter;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(15, 15, 15);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ActiveBorder;
            textBox2.Location = new Point(344, 179);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ShortcutsEnabled = false;
            textBox2.Size = new Size(329, 19);
            textBox2.TabIndex = 11;
            textBox2.Text = "_________________________________________";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(15, 15, 15);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Enabled = false;
            textBox6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.ForeColor = SystemColors.ActiveBorder;
            textBox6.Location = new Point(344, 124);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.ShortcutsEnabled = false;
            textBox6.Size = new Size(329, 19);
            textBox6.TabIndex = 16;
            textBox6.Text = "_________________________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(234, -20);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(472, 25);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(15, 15, 15);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.ActiveBorder;
            txtEmail.Location = new Point(344, 112);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(329, 19);
            txtEmail.TabIndex = 19;
            txtEmail.Enter += txtEmail_Enter;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
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