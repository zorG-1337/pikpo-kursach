
namespace PIKPO_KURSACH
{
    partial class UserPanel
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
            dgvViewer = new System.Windows.Forms.DataGridView();
            search_textBox1 = new System.Windows.Forms.TextBox();
            search_button = new System.Windows.Forms.Button();
            button_profile = new System.Windows.Forms.Button();
            button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvViewer).BeginInit();
            SuspendLayout();
            // 
            // dgvViewer
            // 
            dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewer.Location = new System.Drawing.Point(14, 51);
            dgvViewer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvViewer.Name = "dgvViewer";
            dgvViewer.RowHeadersWidth = 51;
            dgvViewer.RowTemplate.Height = 25;
            dgvViewer.Size = new System.Drawing.Size(853, 548);
            dgvViewer.TabIndex = 0;
            dgvViewer.CellContentClick += dgvViewer_CellContentClick;
            // 
            // search_textBox1
            // 
            search_textBox1.Location = new System.Drawing.Point(14, 12);
            search_textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            search_textBox1.Name = "search_textBox1";
            search_textBox1.Size = new System.Drawing.Size(505, 27);
            search_textBox1.TabIndex = 1;
            // 
            // search_button
            // 
            search_button.Location = new System.Drawing.Point(525, 10);
            search_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            search_button.Name = "search_button";
            search_button.Size = new System.Drawing.Size(86, 31);
            search_button.TabIndex = 5;
            search_button.Text = "Поиск";
            search_button.Click += search_button_Click;
            // 
            // button_profile
            // 
            button_profile.Location = new System.Drawing.Point(781, 12);
            button_profile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button_profile.Name = "button_profile";
            button_profile.Size = new System.Drawing.Size(86, 31);
            button_profile.TabIndex = 3;
            button_profile.Text = "Профиль";
            button_profile.UseVisualStyleBackColor = true;
            button_profile.Click += button_profile_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new System.Drawing.Point(787, 607);
            button_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button_exit.Name = "button_exit";
            button_exit.Size = new System.Drawing.Size(86, 31);
            button_exit.TabIndex = 4;
            button_exit.Text = "Выход";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(880, 648);
            Controls.Add(button_exit);
            Controls.Add(button_profile);
            Controls.Add(search_button);
            Controls.Add(search_textBox1);
            Controls.Add(dgvViewer);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "UserPanel";
            Text = "UserPanel";
            Load += UserPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.TextBox search_textBox1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button button_profile;
        private System.Windows.Forms.Button button_exit;
    }
}