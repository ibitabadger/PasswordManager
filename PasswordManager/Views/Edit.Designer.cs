namespace PasswordManager
{
    partial class Edit
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
            textBoxWeb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxUser = new TextBox();
            label3 = new Label();
            textBoxPassword = new TextBox();
            buttonEditAccount = new Button();
            SuspendLayout();
            // 
            // textBoxWeb
            // 
            textBoxWeb.Location = new Point(11, 89);
            textBoxWeb.Margin = new Padding(3, 2, 3, 2);
            textBoxWeb.Name = "textBoxWeb";
            textBoxWeb.Size = new Size(262, 23);
            textBoxWeb.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(11, 72);
            label1.Name = "label1";
            label1.Size = new Size(58, 16);
            label1.TabIndex = 10;
            label1.Text = "Website";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(11, 130);
            label2.Name = "label2";
            label2.Size = new Size(36, 16);
            label2.TabIndex = 11;
            label2.Text = "User";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(11, 147);
            textBoxUser.Margin = new Padding(3, 2, 3, 2);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(262, 23);
            textBoxUser.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(11, 186);
            label3.Name = "label3";
            label3.Size = new Size(68, 16);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(11, 203);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(262, 23);
            textBoxPassword.TabIndex = 14;
            // 
            // buttonEditAccount
            // 
            buttonEditAccount.BackColor = Color.Teal;
            buttonEditAccount.FlatStyle = FlatStyle.Popup;
            buttonEditAccount.Font = new Font("Arial", 10F);
            buttonEditAccount.ForeColor = SystemColors.Control;
            buttonEditAccount.Location = new Point(70, 246);
            buttonEditAccount.Margin = new Padding(3, 2, 3, 2);
            buttonEditAccount.Name = "buttonEditAccount";
            buttonEditAccount.Size = new Size(143, 31);
            buttonEditAccount.TabIndex = 15;
            buttonEditAccount.Text = "Edit Account";
            buttonEditAccount.UseVisualStyleBackColor = false;
            buttonEditAccount.Click += Btn_Save_CLick;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(286, 450);
            Controls.Add(buttonEditAccount);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxWeb);
            Name = "Edit";
            Text = "Edit";
            Load += Edit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxWeb;
        private Label label1;
        private Label label2;
        private TextBox textBoxUser;
        private Label label3;
        private TextBox textBoxPassword;
        private Button buttonEditAccount;
    }
}