namespace ThesisMain
{
    partial class DocContractForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_docscontrtSearch = new System.Windows.Forms.Button();
            this.textBox_docscontrSearch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DataGridView_DocsContract = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_ManageAbntBottom = new System.Windows.Forms.Panel();
            this.textBox_docscontrAccount = new System.Windows.Forms.TextBox();
            this.label_docsactAccount = new System.Windows.Forms.Label();
            this.dateTimePicker_docscontrDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button_docscontrtInsert = new System.Windows.Forms.Button();
            this.button_docscontrClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DocsContract)).BeginInit();
            this.panel_ManageAbntBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button_docscontrtSearch);
            this.panel1.Controls.Add(this.textBox_docscontrSearch);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 53);
            this.panel1.TabIndex = 69;
            // 
            // button_docscontrtSearch
            // 
            this.button_docscontrtSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_docscontrtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_docscontrtSearch.ForeColor = System.Drawing.Color.White;
            this.button_docscontrtSearch.Location = new System.Drawing.Point(12, 11);
            this.button_docscontrtSearch.Name = "button_docscontrtSearch";
            this.button_docscontrtSearch.Size = new System.Drawing.Size(146, 36);
            this.button_docscontrtSearch.TabIndex = 221;
            this.button_docscontrtSearch.Text = "Поиск";
            this.button_docscontrtSearch.UseVisualStyleBackColor = false;
            this.button_docscontrtSearch.Click += new System.EventHandler(this.button_docscontrtSearch_Click);
            // 
            // textBox_docscontrSearch
            // 
            this.textBox_docscontrSearch.Location = new System.Drawing.Point(164, 15);
            this.textBox_docscontrSearch.Name = "textBox_docscontrSearch";
            this.textBox_docscontrSearch.Size = new System.Drawing.Size(269, 26);
            this.textBox_docscontrSearch.TabIndex = 220;
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
            this.label15.Location = new System.Drawing.Point(674, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Договоры";
            // 
            // DataGridView_DocsContract
            // 
            this.DataGridView_DocsContract.AllowUserToAddRows = false;
            this.DataGridView_DocsContract.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_DocsContract.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_DocsContract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_DocsContract.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_DocsContract.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_DocsContract.ColumnHeadersHeight = 24;
            this.DataGridView_DocsContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_DocsContract.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_DocsContract.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_DocsContract.Location = new System.Drawing.Point(0, 57);
            this.DataGridView_DocsContract.Name = "DataGridView_DocsContract";
            this.DataGridView_DocsContract.ReadOnly = true;
            this.DataGridView_DocsContract.RowHeadersVisible = false;
            this.DataGridView_DocsContract.Size = new System.Drawing.Size(1415, 309);
            this.DataGridView_DocsContract.TabIndex = 70;
            this.DataGridView_DocsContract.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_DocsContract.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_DocsContract.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_DocsContract.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_DocsContract.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_DocsContract.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.DataGridView_DocsContract.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_DocsContract.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_DocsContract.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_DocsContract.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView_DocsContract.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_DocsContract.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_DocsContract.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_DocsContract.ThemeStyle.ReadOnly = true;
            this.DataGridView_DocsContract.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_DocsContract.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_DocsContract.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView_DocsContract.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_DocsContract.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_DocsContract.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_DocsContract.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel_ManageAbntBottom
            // 
            this.panel_ManageAbntBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ManageAbntBottom.Controls.Add(this.textBox_docscontrAccount);
            this.panel_ManageAbntBottom.Controls.Add(this.label_docsactAccount);
            this.panel_ManageAbntBottom.Controls.Add(this.dateTimePicker_docscontrDate);
            this.panel_ManageAbntBottom.Controls.Add(this.label3);
            this.panel_ManageAbntBottom.Controls.Add(this.button_docscontrtInsert);
            this.panel_ManageAbntBottom.Controls.Add(this.button_docscontrClear);
            this.panel_ManageAbntBottom.Controls.Add(this.panel2);
            this.panel_ManageAbntBottom.Location = new System.Drawing.Point(0, 372);
            this.panel_ManageAbntBottom.Name = "panel_ManageAbntBottom";
            this.panel_ManageAbntBottom.Size = new System.Drawing.Size(1415, 207);
            this.panel_ManageAbntBottom.TabIndex = 71;
            // 
            // textBox_docscontrAccount
            // 
            this.textBox_docscontrAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_docscontrAccount.Location = new System.Drawing.Point(444, 28);
            this.textBox_docscontrAccount.Name = "textBox_docscontrAccount";
            this.textBox_docscontrAccount.Size = new System.Drawing.Size(213, 26);
            this.textBox_docscontrAccount.TabIndex = 219;
            // 
            // label_docsactAccount
            // 
            this.label_docsactAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_docsactAccount.AutoSize = true;
            this.label_docsactAccount.BackColor = System.Drawing.SystemColors.Control;
            this.label_docsactAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_docsactAccount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_docsactAccount.Location = new System.Drawing.Point(322, 32);
            this.label_docsactAccount.Name = "label_docsactAccount";
            this.label_docsactAccount.Size = new System.Drawing.Size(120, 19);
            this.label_docsactAccount.TabIndex = 218;
            this.label_docsactAccount.Text = "Номер счета:";
            // 
            // dateTimePicker_docscontrDate
            // 
            this.dateTimePicker_docscontrDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_docscontrDate.Location = new System.Drawing.Point(917, 28);
            this.dateTimePicker_docscontrDate.Name = "dateTimePicker_docscontrDate";
            this.dateTimePicker_docscontrDate.Size = new System.Drawing.Size(196, 26);
            this.dateTimePicker_docscontrDate.TabIndex = 217;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(674, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 19);
            this.label3.TabIndex = 216;
            this.label3.Text = "Дата заключения договора:";
            // 
            // button_docscontrtInsert
            // 
            this.button_docscontrtInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_docscontrtInsert.BackColor = System.Drawing.Color.Green;
            this.button_docscontrtInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_docscontrtInsert.ForeColor = System.Drawing.Color.White;
            this.button_docscontrtInsert.Location = new System.Drawing.Point(600, 164);
            this.button_docscontrtInsert.Name = "button_docscontrtInsert";
            this.button_docscontrtInsert.Size = new System.Drawing.Size(146, 36);
            this.button_docscontrtInsert.TabIndex = 213;
            this.button_docscontrtInsert.Text = "Внести";
            this.button_docscontrtInsert.UseVisualStyleBackColor = false;
            this.button_docscontrtInsert.Click += new System.EventHandler(this.button_docscontrtInsert_Click);
            // 
            // button_docscontrClear
            // 
            this.button_docscontrClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_docscontrClear.BackColor = System.Drawing.Color.Red;
            this.button_docscontrClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_docscontrClear.ForeColor = System.Drawing.Color.White;
            this.button_docscontrClear.Location = new System.Drawing.Point(752, 164);
            this.button_docscontrClear.Name = "button_docscontrClear";
            this.button_docscontrClear.Size = new System.Drawing.Size(146, 36);
            this.button_docscontrClear.TabIndex = 208;
            this.button_docscontrClear.Text = "Очистить";
            this.button_docscontrClear.UseVisualStyleBackColor = false;
            this.button_docscontrClear.Click += new System.EventHandler(this.button_docscontrClear_Click);
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
            // DocContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 580);
            this.Controls.Add(this.panel_ManageAbntBottom);
            this.Controls.Add(this.DataGridView_DocsContract);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DocContractForm";
            this.Text = "DocContractForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DocsContract)).EndInit();
            this.panel_ManageAbntBottom.ResumeLayout(false);
            this.panel_ManageAbntBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_docscontrtSearch;
        private System.Windows.Forms.TextBox textBox_docscontrSearch;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_DocsContract;
        private System.Windows.Forms.Panel panel_ManageAbntBottom;
        private System.Windows.Forms.TextBox textBox_docscontrAccount;
        private System.Windows.Forms.Label label_docsactAccount;
        private System.Windows.Forms.DateTimePicker dateTimePicker_docscontrDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_docscontrtInsert;
        private System.Windows.Forms.Button button_docscontrClear;
        private System.Windows.Forms.Panel panel2;
    }
}