
namespace PIKPO_KURSACH.FormsFromAdminPanel
{
    partial class book_catalog
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
            btn_exit = new System.Windows.Forms.Button();
            textBox_search = new System.Windows.Forms.TextBox();
            button_search = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvViewer).BeginInit();
            SuspendLayout();
            // 
            // dgvViewer
            // 
            dgvViewer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewer.Location = new System.Drawing.Point(14, 57);
            dgvViewer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvViewer.Name = "dgvViewer";
            dgvViewer.RowHeadersWidth = 51;
            dgvViewer.RowTemplate.Height = 25;
            dgvViewer.Size = new System.Drawing.Size(805, 531);
            dgvViewer.TabIndex = 0;
            dgvViewer.CellContentClick += dgvViewer_CellContentClick;
            dgvViewer.CellValueChanged += dgvViewer_CellValueChanged;
            dgvViewer.EditingControlShowing += dgvViewer_EditingControlShowing;
            dgvViewer.UserAddedRow += dgvViewer_UserAddedRow;
            // 
            // btn_exit
            // 
            btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btn_exit.Location = new System.Drawing.Point(733, 597);
            btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new System.Drawing.Size(86, 31);
            btn_exit.TabIndex = 1;
            btn_exit.Text = "Выход";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBox_search.Location = new System.Drawing.Point(14, 16);
            textBox_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new System.Drawing.Size(702, 27);
            textBox_search.TabIndex = 3;
            // 
            // button_search
            // 
            button_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            button_search.Location = new System.Drawing.Point(736, 16);
            button_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button_search.Name = "button_search";
            button_search.Size = new System.Drawing.Size(86, 31);
            button_search.TabIndex = 4;
            button_search.Text = "Поиск";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // book_catalog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(834, 644);
            Controls.Add(button_search);
            Controls.Add(textBox_search);
            Controls.Add(btn_exit);
            Controls.Add(dgvViewer);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "book_catalog";
            Text = "Book Catalog";
            Load += book_catalog_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}