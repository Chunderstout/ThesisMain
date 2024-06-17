namespace ThesisMain
{
    partial class TransactionsForm
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
            this.button_transactionsSearch = new System.Windows.Forms.Button();
            this.textBox_transactionSearch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DataGridView_transactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_ManageAbntBottom = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_transactionsPayment = new System.Windows.Forms.TextBox();
            this.comboBox_transactionsType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_transactionsAccount = new System.Windows.Forms.TextBox();
            this.label_docsactAccount = new System.Windows.Forms.Label();
            this.dateTimePicker_transactionsDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button_transactionsInsert = new System.Windows.Forms.Button();
            this.button_transactionsClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_transactions)).BeginInit();
            this.panel_ManageAbntBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button_transactionsSearch);
            this.panel1.Controls.Add(this.textBox_transactionSearch);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 53);
            this.panel1.TabIndex = 73;
            // 
            // button_transactionsSearch
            // 
            this.button_transactionsSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_transactionsSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_transactionsSearch.ForeColor = System.Drawing.Color.White;
            this.button_transactionsSearch.Location = new System.Drawing.Point(12, 11);
            this.button_transactionsSearch.Name = "button_transactionsSearch";
            this.button_transactionsSearch.Size = new System.Drawing.Size(146, 36);
            this.button_transactionsSearch.TabIndex = 221;
            this.button_transactionsSearch.Text = "Поиск";
            this.button_transactionsSearch.UseVisualStyleBackColor = false;
            this.button_transactionsSearch.Click += new System.EventHandler(this.button_transactionsSearch_Click);
            // 
            // textBox_transactionSearch
            // 
            this.textBox_transactionSearch.Location = new System.Drawing.Point(164, 15);
            this.textBox_transactionSearch.Name = "textBox_transactionSearch";
            this.textBox_transactionSearch.Size = new System.Drawing.Size(269, 27);
            this.textBox_transactionSearch.TabIndex = 220;
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
            this.label15.Size = new System.Drawing.Size(150, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Взаиморассчеты";
            // 
            // DataGridView_transactions
            // 
            this.DataGridView_transactions.AllowUserToAddRows = false;
            this.DataGridView_transactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGridView_transactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView_transactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_transactions.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView_transactions.ColumnHeadersHeight = 24;
            this.DataGridView_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_transactions.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView_transactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_transactions.Location = new System.Drawing.Point(0, 57);
            this.DataGridView_transactions.Name = "DataGridView_transactions";
            this.DataGridView_transactions.ReadOnly = true;
            this.DataGridView_transactions.RowHeadersVisible = false;
            this.DataGridView_transactions.Size = new System.Drawing.Size(1415, 309);
            this.DataGridView_transactions.TabIndex = 74;
            this.DataGridView_transactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_transactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_transactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_transactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_transactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_transactions.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.DataGridView_transactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_transactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_transactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_transactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView_transactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_transactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_transactions.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_transactions.ThemeStyle.ReadOnly = true;
            this.DataGridView_transactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_transactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_transactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView_transactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_transactions.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_transactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_transactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel_ManageAbntBottom
            // 
            this.panel_ManageAbntBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ManageAbntBottom.Controls.Add(this.label6);
            this.panel_ManageAbntBottom.Controls.Add(this.label5);
            this.panel_ManageAbntBottom.Controls.Add(this.label4);
            this.panel_ManageAbntBottom.Controls.Add(this.textBox_transactionsPayment);
            this.panel_ManageAbntBottom.Controls.Add(this.comboBox_transactionsType);
            this.panel_ManageAbntBottom.Controls.Add(this.label2);
            this.panel_ManageAbntBottom.Controls.Add(this.label1);
            this.panel_ManageAbntBottom.Controls.Add(this.textBox_transactionsAccount);
            this.panel_ManageAbntBottom.Controls.Add(this.label_docsactAccount);
            this.panel_ManageAbntBottom.Controls.Add(this.dateTimePicker_transactionsDate);
            this.panel_ManageAbntBottom.Controls.Add(this.label3);
            this.panel_ManageAbntBottom.Controls.Add(this.button_transactionsInsert);
            this.panel_ManageAbntBottom.Controls.Add(this.button_transactionsClear);
            this.panel_ManageAbntBottom.Controls.Add(this.panel2);
            this.panel_ManageAbntBottom.Location = new System.Drawing.Point(0, 372);
            this.panel_ManageAbntBottom.Name = "panel_ManageAbntBottom";
            this.panel_ManageAbntBottom.Size = new System.Drawing.Size(1415, 207);
            this.panel_ManageAbntBottom.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(478, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 19);
            this.label6.TabIndex = 227;
            this.label6.Text = "3 - Плита и Колонка";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(478, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 226;
            this.label5.Text = "2 - Плита";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(478, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 225;
            this.label4.Text = "1 - Отопление";
            // 
            // textBox_transactionsPayment
            // 
            this.textBox_transactionsPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_transactionsPayment.Location = new System.Drawing.Point(856, 35);
            this.textBox_transactionsPayment.Name = "textBox_transactionsPayment";
            this.textBox_transactionsPayment.Size = new System.Drawing.Size(138, 27);
            this.textBox_transactionsPayment.TabIndex = 224;
            // 
            // comboBox_transactionsType
            // 
            this.comboBox_transactionsType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_transactionsType.FormattingEnabled = true;
            this.comboBox_transactionsType.Location = new System.Drawing.Point(482, 33);
            this.comboBox_transactionsType.Name = "comboBox_transactionsType";
            this.comboBox_transactionsType.Size = new System.Drawing.Size(195, 29);
            this.comboBox_transactionsType.TabIndex = 223;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(1011, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 222;
            this.label2.Text = "Дата платежа:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(299, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 220;
            this.label1.Text = "Режим Потребления:";
            // 
            // textBox_transactionsAccount
            // 
            this.textBox_transactionsAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_transactionsAccount.Location = new System.Drawing.Point(145, 35);
            this.textBox_transactionsAccount.Name = "textBox_transactionsAccount";
            this.textBox_transactionsAccount.Size = new System.Drawing.Size(138, 27);
            this.textBox_transactionsAccount.TabIndex = 219;
            // 
            // label_docsactAccount
            // 
            this.label_docsactAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_docsactAccount.AutoSize = true;
            this.label_docsactAccount.BackColor = System.Drawing.SystemColors.Control;
            this.label_docsactAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_docsactAccount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_docsactAccount.Location = new System.Drawing.Point(23, 39);
            this.label_docsactAccount.Name = "label_docsactAccount";
            this.label_docsactAccount.Size = new System.Drawing.Size(120, 19);
            this.label_docsactAccount.TabIndex = 218;
            this.label_docsactAccount.Text = "Номер счета:";
            // 
            // dateTimePicker_transactionsDate
            // 
            this.dateTimePicker_transactionsDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_transactionsDate.Location = new System.Drawing.Point(1147, 35);
            this.dateTimePicker_transactionsDate.Name = "dateTimePicker_transactionsDate";
            this.dateTimePicker_transactionsDate.Size = new System.Drawing.Size(196, 27);
            this.dateTimePicker_transactionsDate.TabIndex = 217;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(708, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 19);
            this.label3.TabIndex = 216;
            this.label3.Text = "Плата абонента: ";
            // 
            // button_transactionsInsert
            // 
            this.button_transactionsInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_transactionsInsert.BackColor = System.Drawing.Color.Green;
            this.button_transactionsInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_transactionsInsert.ForeColor = System.Drawing.Color.White;
            this.button_transactionsInsert.Location = new System.Drawing.Point(594, 160);
            this.button_transactionsInsert.Name = "button_transactionsInsert";
            this.button_transactionsInsert.Size = new System.Drawing.Size(146, 36);
            this.button_transactionsInsert.TabIndex = 213;
            this.button_transactionsInsert.Text = "Внести";
            this.button_transactionsInsert.UseVisualStyleBackColor = false;
            this.button_transactionsInsert.Click += new System.EventHandler(this.button_transactionsInsert_Click);
            // 
            // button_transactionsClear
            // 
            this.button_transactionsClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_transactionsClear.BackColor = System.Drawing.Color.Red;
            this.button_transactionsClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_transactionsClear.ForeColor = System.Drawing.Color.White;
            this.button_transactionsClear.Location = new System.Drawing.Point(746, 160);
            this.button_transactionsClear.Name = "button_transactionsClear";
            this.button_transactionsClear.Size = new System.Drawing.Size(146, 36);
            this.button_transactionsClear.TabIndex = 208;
            this.button_transactionsClear.Text = "Очистить";
            this.button_transactionsClear.UseVisualStyleBackColor = false;
            this.button_transactionsClear.Click += new System.EventHandler(this.button_transactionsClear_Click);
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
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 580);
            this.Controls.Add(this.panel_ManageAbntBottom);
            this.Controls.Add(this.DataGridView_transactions);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TransactionsForm";
            this.Text = "TransactionsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_transactions)).EndInit();
            this.panel_ManageAbntBottom.ResumeLayout(false);
            this.panel_ManageAbntBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_transactionsSearch;
        private System.Windows.Forms.TextBox textBox_transactionSearch;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_transactions;
        private System.Windows.Forms.Panel panel_ManageAbntBottom;
        private System.Windows.Forms.ComboBox comboBox_transactionsType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_transactionsAccount;
        private System.Windows.Forms.Label label_docsactAccount;
        private System.Windows.Forms.DateTimePicker dateTimePicker_transactionsDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_transactionsInsert;
        private System.Windows.Forms.Button button_transactionsClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_transactionsPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}