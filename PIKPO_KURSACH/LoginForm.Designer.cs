
namespace PIKPO_KURSACH
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
            textBox_login = new System.Windows.Forms.TextBox();
            textBox_password = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btn_login = new System.Windows.Forms.Button();
            error = new System.Windows.Forms.Label();
            registration = new System.Windows.Forms.Button();
            label_login = new System.Windows.Forms.Label();
            label_password = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // textBox_login
            // 
            textBox_login.Location = new System.Drawing.Point(137, 105);
            textBox_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new System.Drawing.Size(174, 27);
            textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            textBox_password.Location = new System.Drawing.Point(137, 144);
            textBox_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new System.Drawing.Size(174, 27);
            textBox_password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(107, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(255, 20);
            label1.TabIndex = 2;
            label1.Text = "Здравствуйте! Мы рады видеть вас!";
            label1.Click += label1_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new System.Drawing.Point(107, 179);
            btn_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_login.Name = "btn_login";
            btn_login.Size = new System.Drawing.Size(109, 36);
            btn_login.TabIndex = 3;
            btn_login.Text = "Вход";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // error
            // 
            error.AutoSize = true;
            error.Location = new System.Drawing.Point(14, 289);
            error.Name = "error";
            error.Size = new System.Drawing.Size(0, 20);
            error.TabIndex = 4;
            // 
            // registration
            // 
            registration.Location = new System.Drawing.Point(222, 179);
            registration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            registration.Name = "registration";
            registration.Size = new System.Drawing.Size(109, 36);
            registration.TabIndex = 5;
            registration.Text = "Регистрация";
            registration.UseVisualStyleBackColor = true;
            registration.Click += registration_Click;
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Location = new System.Drawing.Point(79, 108);
            label_login.Name = "label_login";
            label_login.Size = new System.Drawing.Size(52, 20);
            label_login.TabIndex = 6;
            label_login.Text = "Логин";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new System.Drawing.Point(69, 147);
            label_password.Name = "label_password";
            label_password.Size = new System.Drawing.Size(62, 20);
            label_password.TabIndex = 7;
            label_password.Text = "Пароль";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(456, 321);
            Controls.Add(label_password);
            Controls.Add(label_login);
            Controls.Add(registration);
            Controls.Add(error);
            Controls.Add(btn_login);
            Controls.Add(label1);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Authorization form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        public System.Windows.Forms.TextBox textBox_login;
        public System.Windows.Forms.TextBox textBox_password;
    }
}

