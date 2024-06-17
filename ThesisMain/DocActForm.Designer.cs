namespace ThesisMain
{
    partial class DocActForm
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
            this.label15 = new System.Windows.Forms.Label();
            this.DataGridView_DocsAct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_ManageAbntBottom = new System.Windows.Forms.Panel();
            this.textBox_docsactAccount = new System.Windows.Forms.TextBox();
            this.label_docsactAccount = new System.Windows.Forms.Label();
            this.dateTimePicker_docsactDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_docsactPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_docsactInsert = new System.Windows.Forms.Button();
            this.button_docsactClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_docsactEquipment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_docsactSearch = new System.Windows.Forms.Button();
            this.textBox_docsactSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DocsAct)).BeginInit();
            this.panel_ManageAbntBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button_docsactSearch);
            this.panel1.Controls.Add(this.textBox_docsactSearch);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 53);
            this.panel1.TabIndex = 68;
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
            this.label15.Location = new System.Drawing.Point(681, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Акты";
            // 
            // DataGridView_DocsAct
            // 
            this.DataGridView_DocsAct.AllowUserToAddRows = false;
            this.DataGridView_DocsAct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGridView_DocsAct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView_DocsAct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_DocsAct.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_DocsAct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView_DocsAct.ColumnHeadersHeight = 24;
            this.DataGridView_DocsAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_DocsAct.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView_DocsAct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_DocsAct.Location = new System.Drawing.Point(0, 57);
            this.DataGridView_DocsAct.Name = "DataGridView_DocsAct";
            this.DataGridView_DocsAct.ReadOnly = true;
            this.DataGridView_DocsAct.RowHeadersVisible = false;
            this.DataGridView_DocsAct.Size = new System.Drawing.Size(1415, 309);
            this.DataGridView_DocsAct.TabIndex = 69;
            this.DataGridView_DocsAct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_DocsAct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_DocsAct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_DocsAct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_DocsAct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_DocsAct.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.DataGridView_DocsAct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_DocsAct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_DocsAct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_DocsAct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView_DocsAct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_DocsAct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_DocsAct.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_DocsAct.ThemeStyle.ReadOnly = true;
            this.DataGridView_DocsAct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_DocsAct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_DocsAct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView_DocsAct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_DocsAct.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_DocsAct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_DocsAct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel_ManageAbntBottom
            // 
            this.panel_ManageAbntBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ManageAbntBottom.Controls.Add(this.textBox_docsactAccount);
            this.panel_ManageAbntBottom.Controls.Add(this.label_docsactAccount);
            this.panel_ManageAbntBottom.Controls.Add(this.dateTimePicker_docsactDate);
            this.panel_ManageAbntBottom.Controls.Add(this.label3);
            this.panel_ManageAbntBottom.Controls.Add(this.textBox_docsactPrice);
            this.panel_ManageAbntBottom.Controls.Add(this.label2);
            this.panel_ManageAbntBottom.Controls.Add(this.button_docsactInsert);
            this.panel_ManageAbntBottom.Controls.Add(this.button_docsactClear);
            this.panel_ManageAbntBottom.Controls.Add(this.panel2);
            this.panel_ManageAbntBottom.Controls.Add(this.textBox_docsactEquipment);
            this.panel_ManageAbntBottom.Controls.Add(this.label1);
            this.panel_ManageAbntBottom.Location = new System.Drawing.Point(0, 372);
            this.panel_ManageAbntBottom.Name = "panel_ManageAbntBottom";
            this.panel_ManageAbntBottom.Size = new System.Drawing.Size(1415, 207);
            this.panel_ManageAbntBottom.TabIndex = 70;
            // 
            // textBox_docsactAccount
            // 
            this.textBox_docsactAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_docsactAccount.Location = new System.Drawing.Point(234, 72);
            this.textBox_docsactAccount.Name = "textBox_docsactAccount";
            this.textBox_docsactAccount.Size = new System.Drawing.Size(213, 27);
            this.textBox_docsactAccount.TabIndex = 219;
            // 
            // label_docsactAccount
            // 
            this.label_docsactAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_docsactAccount.AutoSize = true;
            this.label_docsactAccount.BackColor = System.Drawing.SystemColors.Control;
            this.label_docsactAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_docsactAccount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_docsactAccount.Location = new System.Drawing.Point(112, 76);
            this.label_docsactAccount.Name = "label_docsactAccount";
            this.label_docsactAccount.Size = new System.Drawing.Size(120, 19);
            this.label_docsactAccount.TabIndex = 218;
            this.label_docsactAccount.Text = "Номер счета:";
            // 
            // dateTimePicker_docsactDate
            // 
            this.dateTimePicker_docsactDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_docsactDate.Location = new System.Drawing.Point(1122, 28);
            this.dateTimePicker_docsactDate.Name = "dateTimePicker_docsactDate";
            this.dateTimePicker_docsactDate.Size = new System.Drawing.Size(196, 27);
            this.dateTimePicker_docsactDate.TabIndex = 217;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(905, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 19);
            this.label3.TabIndex = 216;
            this.label3.Text = "Дата проведения работ:";
            // 
            // textBox_docsactPrice
            // 
            this.textBox_docsactPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_docsactPrice.Location = new System.Drawing.Point(676, 28);
            this.textBox_docsactPrice.Name = "textBox_docsactPrice";
            this.textBox_docsactPrice.Size = new System.Drawing.Size(213, 27);
            this.textBox_docsactPrice.TabIndex = 215;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(564, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 214;
            this.label2.Text = "Цена работ:";
            // 
            // button_docsactInsert
            // 
            this.button_docsactInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_docsactInsert.BackColor = System.Drawing.Color.Green;
            this.button_docsactInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_docsactInsert.ForeColor = System.Drawing.Color.White;
            this.button_docsactInsert.Location = new System.Drawing.Point(600, 164);
            this.button_docsactInsert.Name = "button_docsactInsert";
            this.button_docsactInsert.Size = new System.Drawing.Size(146, 36);
            this.button_docsactInsert.TabIndex = 213;
            this.button_docsactInsert.Text = "Внести";
            this.button_docsactInsert.UseVisualStyleBackColor = false;
            this.button_docsactInsert.Click += new System.EventHandler(this.button_docsactInsert_Click);
            // 
            // button_docsactClear
            // 
            this.button_docsactClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_docsactClear.BackColor = System.Drawing.Color.Red;
            this.button_docsactClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_docsactClear.ForeColor = System.Drawing.Color.White;
            this.button_docsactClear.Location = new System.Drawing.Point(752, 164);
            this.button_docsactClear.Name = "button_docsactClear";
            this.button_docsactClear.Size = new System.Drawing.Size(146, 36);
            this.button_docsactClear.TabIndex = 208;
            this.button_docsactClear.Text = "Очистить";
            this.button_docsactClear.UseVisualStyleBackColor = false;
            this.button_docsactClear.Click += new System.EventHandler(this.button_docsactClear_Click);
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
            // textBox_docsactEquipment
            // 
            this.textBox_docsactEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_docsactEquipment.Location = new System.Drawing.Point(234, 28);
            this.textBox_docsactEquipment.Name = "textBox_docsactEquipment";
            this.textBox_docsactEquipment.Size = new System.Drawing.Size(319, 27);
            this.textBox_docsactEquipment.TabIndex = 177;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(68, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 176;
            this.label1.Text = "Вид оборудования:";
            // 
            // button_docsactSearch
            // 
            this.button_docsactSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_docsactSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_docsactSearch.ForeColor = System.Drawing.Color.White;
            this.button_docsactSearch.Location = new System.Drawing.Point(12, 11);
            this.button_docsactSearch.Name = "button_docsactSearch";
            this.button_docsactSearch.Size = new System.Drawing.Size(146, 36);
            this.button_docsactSearch.TabIndex = 221;
            this.button_docsactSearch.Text = "Поиск";
            this.button_docsactSearch.UseVisualStyleBackColor = false;
            this.button_docsactSearch.Click += new System.EventHandler(this.button_docsactSearch_Click);
            // 
            // textBox_docsactSearch
            // 
            this.textBox_docsactSearch.Location = new System.Drawing.Point(164, 15);
            this.textBox_docsactSearch.Name = "textBox_docsactSearch";
            this.textBox_docsactSearch.Size = new System.Drawing.Size(269, 27);
            this.textBox_docsactSearch.TabIndex = 220;
            // 
            // DocActForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 580);
            this.Controls.Add(this.panel_ManageAbntBottom);
            this.Controls.Add(this.DataGridView_DocsAct);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DocActForm";
            this.Text = "DocActForm";
            this.Load += new System.EventHandler(this.DocActForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_DocsAct)).EndInit();
            this.panel_ManageAbntBottom.ResumeLayout(false);
            this.panel_ManageAbntBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_DocsAct;
        private System.Windows.Forms.Panel panel_ManageAbntBottom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_docsactPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_docsactInsert;
        private System.Windows.Forms.Button button_docsactClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_docsactEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_docsactDate;
        private System.Windows.Forms.TextBox textBox_docsactAccount;
        private System.Windows.Forms.Label label_docsactAccount;
        private System.Windows.Forms.Button button_docsactSearch;
        private System.Windows.Forms.TextBox textBox_docsactSearch;
    }
}