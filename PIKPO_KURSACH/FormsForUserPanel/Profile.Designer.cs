
namespace PIKPO_KURSACH.FormsForUserPanel
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            label_login = new System.Windows.Forms.Label();
            label_password = new System.Windows.Forms.Label();
            login = new System.Windows.Forms.Label();
            password = new System.Windows.Forms.Label();
            count_books = new System.Windows.Forms.Label();
            count = new System.Windows.Forms.Label();
            button_exit = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.ForeColor = System.Drawing.SystemColors.ControlText;
            label_login.Location = new System.Drawing.Point(13, 143);
            label_login.Name = "label_login";
            label_login.Size = new System.Drawing.Size(86, 20);
            label_login.TabIndex = 0;
            label_login.Text = "Ваш логин:";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new System.Drawing.Point(13, 168);
            label_password.Name = "label_password";
            label_password.Size = new System.Drawing.Size(96, 20);
            label_password.TabIndex = 1;
            label_password.Text = "Ваш пароль:";
            label_password.Click += label_password_Click;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Location = new System.Drawing.Point(101, 143);
            login.Name = "login";
            login.Size = new System.Drawing.Size(43, 20);
            login.TabIndex = 2;
            login.Text = "login";
            login.Click += login_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new System.Drawing.Point(101, 168);
            password.Name = "password";
            password.Size = new System.Drawing.Size(72, 20);
            password.TabIndex = 3;
            password.Text = "password";
            // 
            // count_books
            // 
            count_books.AutoSize = true;
            count_books.Location = new System.Drawing.Point(13, 193);
            count_books.Name = "count_books";
            count_books.Size = new System.Drawing.Size(207, 20);
            count_books.TabIndex = 4;
            count_books.Text = "Количество купленных книг:";
            // 
            // count
            // 
            count.AutoSize = true;
            count.Location = new System.Drawing.Point(226, 193);
            count.Name = "count";
            count.Size = new System.Drawing.Size(17, 20);
            count.TabIndex = 5;
            count.Text = "0";
            // 
            // button_exit
            // 
            button_exit.Location = new System.Drawing.Point(195, 263);
            button_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button_exit.Name = "button_exit";
            button_exit.Size = new System.Drawing.Size(86, 31);
            button_exit.TabIndex = 7;
            button_exit.Text = "Выход";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(15, 17);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(129, 121);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Profile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(295, 309);
            Controls.Add(pictureBox1);
            Controls.Add(button_exit);
            Controls.Add(count);
            Controls.Add(count_books);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(label_password);
            Controls.Add(label_login);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Profile";
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        public System.Windows.Forms.Label login;
        public System.Windows.Forms.Label password;
        private System.Windows.Forms.Label count_books;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}