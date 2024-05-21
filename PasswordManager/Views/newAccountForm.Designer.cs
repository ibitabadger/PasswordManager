namespace AddAccount
{
    partial class newAccountForm
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxPassword = new TextBox();
            textBoxUser = new TextBox();
            textBoxWeb = new TextBox();
            buttonAddAccount = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 166);
            label3.Name = "label3";
            label3.Size = new Size(68, 16);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(36, 16);
            label2.TabIndex = 10;
            label2.Text = "User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(58, 16);
            label1.TabIndex = 9;
            label1.Text = "Website";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 185);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(275, 23);
            textBoxPassword.TabIndex = 8;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(12, 132);
            textBoxUser.Margin = new Padding(3, 2, 3, 2);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(275, 23);
            textBoxUser.TabIndex = 7;
            // 
            // textBoxWeb
            // 
            textBoxWeb.Location = new Point(12, 77);
            textBoxWeb.Margin = new Padding(3, 2, 3, 2);
            textBoxWeb.Name = "textBoxWeb";
            textBoxWeb.Size = new Size(275, 23);
            textBoxWeb.TabIndex = 6;
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.BackColor = Color.Teal;
            buttonAddAccount.FlatStyle = FlatStyle.Popup;
            buttonAddAccount.ForeColor = SystemColors.Control;
            buttonAddAccount.Location = new Point(73, 245);
            buttonAddAccount.Margin = new Padding(3, 2, 3, 2);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new Size(143, 31);
            buttonAddAccount.TabIndex = 12;
            buttonAddAccount.Text = "Add Account";
            buttonAddAccount.UseVisualStyleBackColor = false;
            buttonAddAccount.Click += button1_Click;
            // 
            // newAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(299, 361);
            Controls.Add(buttonAddAccount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUser);
            Controls.Add(textBoxWeb);
            Font = new Font("Arial", 10F);
            ForeColor = SystemColors.Control;
            Margin = new Padding(3, 2, 3, 2);
            Name = "newAccountForm";
            Text = "New Account";
            Load += newAccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxPassword;
        private TextBox textBoxUser;
        private TextBox textBoxWeb;
        private Button buttonAddAccount;
    }
}
