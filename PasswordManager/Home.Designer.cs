
namespace PasswordManager
{
    partial class Home
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
            button1 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(77, 52);
            button1.Name = "button1";
            button1.Size = new Size(139, 36);
            button1.TabIndex = 2;
            button1.Text = "Add Account";
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Location = new Point(54, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 169);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Home";
            Text = "Password Manager";
            ResumeLayout(false);
        }



        #endregion


        private Button button1;
        private Panel panel1;
    }
}
