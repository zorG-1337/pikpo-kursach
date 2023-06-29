
namespace PIKPO_KURSACH
{
    partial class AdminPanel
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
            book_catalog = new System.Windows.Forms.Button();
            user_button = new System.Windows.Forms.Button();
            exit_button = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // book_catalog
            // 
            book_catalog.Location = new System.Drawing.Point(14, 30);
            book_catalog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            book_catalog.Name = "book_catalog";
            book_catalog.Size = new System.Drawing.Size(239, 110);
            book_catalog.TabIndex = 1;
            book_catalog.Text = "Каталог";
            book_catalog.UseVisualStyleBackColor = true;
            book_catalog.Click += book_catalog_Click;
            // 
            // user_button
            // 
            user_button.Location = new System.Drawing.Point(15, 149);
            user_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            user_button.Name = "user_button";
            user_button.Size = new System.Drawing.Size(238, 108);
            user_button.TabIndex = 2;
            user_button.Text = "Все пользователи";
            user_button.UseVisualStyleBackColor = true;
            user_button.Click += user_button_Click;
            // 
            // exit_button
            // 
            exit_button.Location = new System.Drawing.Point(175, 265);
            exit_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            exit_button.Name = "exit_button";
            exit_button.Size = new System.Drawing.Size(86, 31);
            exit_button.TabIndex = 3;
            exit_button.Text = "Выход";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(274, 312);
            Controls.Add(exit_button);
            Controls.Add(user_button);
            Controls.Add(book_catalog);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AdminPanel";
            Text = "AdminPanel";
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button book_catalog;
        private System.Windows.Forms.Button user_button;
        private System.Windows.Forms.Button exit_button;
    }
}