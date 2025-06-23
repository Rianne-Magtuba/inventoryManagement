namespace inventoryManagementGUI
{
    partial class LoginForm
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
            loginBtn = new Button();
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userNameField = new TextBox();
            passField = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(45, 45, 45);
            loginBtn.ForeColor = SystemColors.Window;
            loginBtn.Location = new Point(459, 418);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(112, 48);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(45, 45, 45);
            btnClear.ForeColor = SystemColors.Window;
            btnClear.Location = new Point(259, 418);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 48);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(45, 45, 45);
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(349, 28);
            label1.Name = "label1";
            label1.Size = new Size(134, 60);
            label1.TabIndex = 2;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(140, 209);
            label2.Name = "label2";
            label2.Size = new Size(163, 41);
            label2.TabIndex = 3;
            label2.Text = "username: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(143, 312);
            label3.Name = "label3";
            label3.Size = new Size(160, 41);
            label3.TabIndex = 4;
            label3.Text = "password: ";
            // 
            // userNameField
            // 
            userNameField.Font = new Font("Segoe UI", 15F);
            userNameField.Location = new Point(328, 203);
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(243, 47);
            userNameField.TabIndex = 5;
            // 
            // passField
            // 
            passField.Font = new Font("Segoe UI", 15F);
            passField.Location = new Point(328, 309);
            passField.Name = "passField";
            passField.PasswordChar = '*';
            passField.Size = new Size(243, 47);
            passField.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 115);
            panel1.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(800, 526);
            Controls.Add(passField);
            Controls.Add(userNameField);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(loginBtn);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "Login Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        public Button buttonProp(Button button1)
        {
            Button button = button1;

            //button.BackColor = Color.FromArgb(255, 45, 45);
            //button.ForeColor = SystemColors.Window;
           

            return button;
        }
        #endregion

        private Button loginBtn;
        private Button btnClear;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userNameField;
        private TextBox passField;
        private Panel panel1;
    }
}
