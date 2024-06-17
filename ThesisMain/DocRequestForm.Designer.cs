namespace ThesisMain
{
    partial class DocRequestForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_docsreqSearch = new System.Windows.Forms.Button();
            this.textBox_docsreqSearch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DataGridView_DocsRequest = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_ManageAbntBottom = new System.Windows.Forms.Panel();
            this.textBox_docsreqEqmodel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_docsreqAccount = new System.Windows.Forms.TextBox();
            this.label_docsactAccount = new System.Windows.Forms.Label();
            this.dateTimePicker_docsreqDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button_docsreqInsert = new System.Windows.Forms.Button();
            this.button_docsreqClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DocsRequest)).BeginInit();
            this.panel_ManageAbntBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button_docsreqSearch);
            this.panel1.Controls.Add(this.textBox_docsreqSearch);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 53);
            this.panel1.TabIndex = 70;
            // 
            // button_docsreqSearch
            // 
            this.button_docsreqSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_docsreqSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_docsreqSearch.ForeColor = System.Drawing.Color.White;
            this.button_docsreqSearch.Location = new System.Drawing.Point(12, 11);
            this.button_docsreqSearch.Name = "button_docsreqSearch";
            this.button_docsreqSearch.Size = new System.Drawing.Size(146, 36);
            this.button_docsreqSearch.TabIndex = 221;
            this.button_docsreqSearch.Text = "Поиск";
            this.button_docsreqSearch.UseVisualStyleBackColor = false;
            this.button_docsreqSearch.Click += new System.EventHandler(this.button_docsreqSearch_Click);
            // 
            // textBox_docsreqSearch
            // 
            this.textBox_docsreqSearch.Location = new System.Drawing.Point(164, 15);
            this.textBox_docsreqSearch.Name = "textBox_docsreqSearch";
            this.textBox_docsreqSearch.Size = new System.Drawing.Size(269, 26);
            this.textBox_docsreqSearch.TabIndex = 220;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.RoyalBlue;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(680, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Заявки";
            // 
            // DataGridView_DocsRequest
            // 
            this.DataGridView_DocsRequest.AllowUserToAddRows = false;
            this.DataGridView_DocsRequest.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGridView_DocsRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView_DocsRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_DocsRequest.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_DocsRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView_DocsRequest.ColumnHeadersHeight = 24;
            this.DataGridView_DocsRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_DocsRequest.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView_DocsRequest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_DocsRequest.Location = new System.Drawing.Point(0, 57);
            this.DataGridView_DocsRequest.Name = "DataGridView_DocsRequest";
            this.DataGridView_DocsRequest.ReadOnly = true;
            this.DataGridView_DocsRequest.RowHeadersVisible = false;
            this.DataGridView_DocsRequest.Size = new System.Drawing.Size(1415, 309);
            this.DataGridView_DocsRequest.TabIndex = 71;
            this.DataGridView_DocsRequest.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_DocsRequest.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_DocsRequest.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_DocsRequest.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_DocsRequest.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_DocsRequest.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.DataGridView_DocsRequest.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_DocsRequest.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_DocsRequest.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_DocsRequest.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView_DocsRequest.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_DocsRequest.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_DocsRequest.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_DocsRequest.ThemeStyle.ReadOnly = true;
            this.DataGridView_DocsRequest.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_DocsRequest.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_DocsRequest.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView_DocsRequest.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_DocsRequest.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_DocsRequest.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_DocsRequest.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel_ManageAbntBottom
            // 
            this.panel_ManageAbntBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ManageAbntBottom.Controls.Add(this.textBox_docsreqEqmodel);
            this.panel_ManageAbntBottom.Controls.Add(this.label1);
            this.panel_ManageAbntBottom.Controls.Add(this.textBox_docsreqAccount);
            this.panel_ManageAbntBottom.Controls.Add(this.label_docsactAccount);
            this.panel_ManageAbntBottom.Controls.Add(this.dateTimePicker_docsreqDate);
            this.panel_ManageAbntBottom.Controls.Add(this.label3);
            this.panel_ManageAbntBottom.Controls.Add(this.button_docsreqInsert);
            this.panel_ManageAbntBottom.Controls.Add(this.button_docsreqClear);
            this.panel_ManageAbntBottom.Controls.Add(this.panel2);
            this.panel_ManageAbntBottom.Location = new System.Drawing.Point(0, 371);
            this.panel_ManageAbntBottom.Name = "panel_ManageAbntBottom";
            this.panel_ManageAbntBottom.Size = new System.Drawing.Size(1415, 207);
            this.panel_ManageAbntBottom.TabIndex = 72;
            // 
            // textBox_docsreqEqmodel
            // 
            this.textBox_docsreqEqmodel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_docsreqEqmodel.Location = new System.Drawing.Point(586, 33);
            this.textBox_docsreqEqmodel.Name = "textBox_docsreqEqmodel";
            this.textBox_docsreqEqmodel.Size = new System.Drawing.Size(213, 26);
            this.textBox_docsreqEqmodel.TabIndex = 221;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(444, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 220;
            this.label1.Text = "Оборудование:";
            // 
            // textBox_docsreqAccount
            // 
            this.textBox_docsreqAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_docsreqAccount.Location = new System.Drawing.Point(267, 33);
            this.textBox_docsreqAccount.Name = "textBox_docsreqAccount";
            this.textBox_docsreqAccount.Size = new System.Drawing.Size(167, 26);
            this.textBox_docsreqAccount.TabIndex = 219;
            // 
            // label_docsactAccount
            // 
            this.label_docsactAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_docsactAccount.AutoSize = true;
            this.label_docsactAccount.BackColor = System.Drawing.SystemColors.Control;
            this.label_docsactAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_docsactAccount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_docsactAccount.Location = new System.Drawing.Point(145, 37);
            this.label_docsactAccount.Name = "label_docsactAccount";
            this.label_docsactAccount.Size = new System.Drawing.Size(120, 19);
            this.label_docsactAccount.TabIndex = 218;
            this.label_docsactAccount.Text = "Номер счета:";
            // 
            // dateTimePicker_docsreqDate
            // 
            this.dateTimePicker_docsreqDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_docsreqDate.Location = new System.Drawing.Point(1029, 33);
            this.dateTimePicker_docsreqDate.Name = "dateTimePicker_docsreqDate";
            this.dateTimePicker_docsreqDate.Size = new System.Drawing.Size(196, 26);
            this.dateTimePicker_docsreqDate.TabIndex = 217;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(812, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 19);
            this.label3.TabIndex = 216;
            this.label3.Text = "Дата проведения работ:";
            // 
            // button_docsreqInsert
            // 
            this.button_docsreqInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_docsreqInsert.BackColor = System.Drawing.Color.Green;
            this.button_docsreqInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_docsreqInsert.ForeColor = System.Drawing.Color.White;
            this.button_docsreqInsert.Location = new System.Drawing.Point(558, 161);
            this.button_docsreqInsert.Name = "button_docsreqInsert";
            this.button_docsreqInsert.Size = new System.Drawing.Size(146, 36);
            this.button_docsreqInsert.TabIndex = 213;
            this.button_docsreqInsert.Text = "Внести";
            this.button_docsreqInsert.UseVisualStyleBackColor = false;
            this.button_docsreqInsert.Click += new System.EventHandler(this.button_docsreqInsert_Click);
            // 
            // button_docsreqClear
            // 
            this.button_docsreqClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_docsreqClear.BackColor = System.Drawing.Color.Red;
            this.button_docsreqClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_docsreqClear.ForeColor = System.Drawing.Color.White;
            this.button_docsreqClear.Location = new System.Drawing.Point(710, 161);
            this.button_docsreqClear.Name = "button_docsreqClear";
            this.button_docsreqClear.Size = new System.Drawing.Size(146, 36);
            this.button_docsreqClear.TabIndex = 208;
            this.button_docsreqClear.Text = "Очистить";
            this.button_docsreqClear.UseVisualStyleBackColor = false;
            this.button_docsreqClear.Click += new System.EventHandler(this.button_docsreqClear_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(-8, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1431, 12);
            this.panel2.TabIndex = 207;
            // 
            // DocRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 580);
            this.Controls.Add(this.panel_ManageAbntBottom);
            this.Controls.Add(this.DataGridView_DocsRequest);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DocRequestForm";
            this.Text = "DocRequestForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DocsRequest)).EndInit();
            this.panel_ManageAbntBottom.ResumeLayout(false);
            this.panel_ManageAbntBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_docsreqSearch;
        private System.Windows.Forms.TextBox textBox_docsreqSearch;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_DocsRequest;
        private System.Windows.Forms.Panel panel_ManageAbntBottom;
        private System.Windows.Forms.TextBox textBox_docsreqEqmodel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_docsreqAccount;
        private System.Windows.Forms.Label label_docsactAccount;
        private System.Windows.Forms.DateTimePicker dateTimePicker_docsreqDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_docsreqInsert;
        private System.Windows.Forms.Button button_docsreqClear;
        private System.Windows.Forms.Panel panel2;
    }
}