namespace ThesisMain
{
    partial class EquipmentCountersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_equipcountSearch = new System.Windows.Forms.Button();
            this.textBox_equipcountSearch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DataGridView_equipmentCounters = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_ManageAbntBottom = new System.Windows.Forms.Panel();
            this.textBox_equipcountLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_equipcountModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_equipcountAccount = new System.Windows.Forms.TextBox();
            this.label_docsactAccount = new System.Windows.Forms.Label();
            this.dateTimePicker_equipcountDateval = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button_equipcountInsert = new System.Windows.Forms.Button();
            this.button_equipcountClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_equipmentCounters)).BeginInit();
            this.panel_ManageAbntBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button_equipcountSearch);
            this.panel1.Controls.Add(this.textBox_equipcountSearch);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 53);
            this.panel1.TabIndex = 71;
            // 
            // button_equipcountSearch
            // 
            this.button_equipcountSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_equipcountSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_equipcountSearch.ForeColor = System.Drawing.Color.White;
            this.button_equipcountSearch.Location = new System.Drawing.Point(12, 11);
            this.button_equipcountSearch.Name = "button_equipcountSearch";
            this.button_equipcountSearch.Size = new System.Drawing.Size(146, 36);
            this.button_equipcountSearch.TabIndex = 221;
            this.button_equipcountSearch.Text = "Поиск";
            this.button_equipcountSearch.UseVisualStyleBackColor = false;
            this.button_equipcountSearch.Click += new System.EventHandler(this.button_equipcountSearch_Click);
            // 
            // textBox_equipcountSearch
            // 
            this.textBox_equipcountSearch.Location = new System.Drawing.Point(164, 15);
            this.textBox_equipcountSearch.Name = "textBox_equipcountSearch";
            this.textBox_equipcountSearch.Size = new System.Drawing.Size(269, 27);
            this.textBox_equipcountSearch.TabIndex = 220;
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
            this.label15.Size = new System.Drawing.Size(86, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "Счетчики";
            // 
            // DataGridView_equipmentCounters
            // 
            this.DataGridView_equipmentCounters.AllowUserToAddRows = false;
            this.DataGridView_equipmentCounters.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView_equipmentCounters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_equipmentCounters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_equipmentCounters.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_equipmentCounters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_equipmentCounters.ColumnHeadersHeight = 24;
            this.DataGridView_equipmentCounters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_equipmentCounters.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_equipmentCounters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_equipmentCounters.Location = new System.Drawing.Point(0, 57);
            this.DataGridView_equipmentCounters.Name = "DataGridView_equipmentCounters";
            this.DataGridView_equipmentCounters.ReadOnly = true;
            this.DataGridView_equipmentCounters.RowHeadersVisible = false;
            this.DataGridView_equipmentCounters.Size = new System.Drawing.Size(1415, 309);
            this.DataGridView_equipmentCounters.TabIndex = 72;
            this.DataGridView_equipmentCounters.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_equipmentCounters.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_equipmentCounters.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_equipmentCounters.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_equipmentCounters.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_equipmentCounters.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.DataGridView_equipmentCounters.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_equipmentCounters.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_equipmentCounters.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_equipmentCounters.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView_equipmentCounters.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_equipmentCounters.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_equipmentCounters.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_equipmentCounters.ThemeStyle.ReadOnly = true;
            this.DataGridView_equipmentCounters.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_equipmentCounters.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_equipmentCounters.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView_equipmentCounters.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_equipmentCounters.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_equipmentCounters.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_equipmentCounters.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel_ManageAbntBottom
            // 
            this.panel_ManageAbntBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ManageAbntBottom.Controls.Add(this.textBox_equipcountLocation);
            this.panel_ManageAbntBottom.Controls.Add(this.label2);
            this.panel_ManageAbntBottom.Controls.Add(this.textBox_equipcountModel);
            this.panel_ManageAbntBottom.Controls.Add(this.label1);
            this.panel_ManageAbntBottom.Controls.Add(this.textBox_equipcountAccount);
            this.panel_ManageAbntBottom.Controls.Add(this.label_docsactAccount);
            this.panel_ManageAbntBottom.Controls.Add(this.dateTimePicker_equipcountDateval);
            this.panel_ManageAbntBottom.Controls.Add(this.label3);
            this.panel_ManageAbntBottom.Controls.Add(this.button_equipcountInsert);
            this.panel_ManageAbntBottom.Controls.Add(this.button_equipcountClear);
            this.panel_ManageAbntBottom.Controls.Add(this.panel2);
            this.panel_ManageAbntBottom.Location = new System.Drawing.Point(0, 370);
            this.panel_ManageAbntBottom.Name = "panel_ManageAbntBottom";
            this.panel_ManageAbntBottom.Size = new System.Drawing.Size(1415, 207);
            this.panel_ManageAbntBottom.TabIndex = 73;
            // 
            // textBox_equipcountLocation
            // 
            this.textBox_equipcountLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_equipcountLocation.Location = new System.Drawing.Point(523, 82);
            this.textBox_equipcountLocation.Name = "textBox_equipcountLocation";
            this.textBox_equipcountLocation.Size = new System.Drawing.Size(481, 27);
            this.textBox_equipcountLocation.TabIndex = 223;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(303, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 19);
            this.label2.TabIndex = 222;
            this.label2.Text = "Расположение счетчика:";
            // 
            // textBox_equipcountModel
            // 
            this.textBox_equipcountModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_equipcountModel.Location = new System.Drawing.Point(596, 33);
            this.textBox_equipcountModel.Name = "textBox_equipcountModel";
            this.textBox_equipcountModel.Size = new System.Drawing.Size(330, 27);
            this.textBox_equipcountModel.TabIndex = 221;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(436, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 220;
            this.label1.Text = "Модель счетчика:";
            // 
            // textBox_equipcountAccount
            // 
            this.textBox_equipcountAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_equipcountAccount.Location = new System.Drawing.Point(190, 33);
            this.textBox_equipcountAccount.Name = "textBox_equipcountAccount";
            this.textBox_equipcountAccount.Size = new System.Drawing.Size(167, 27);
            this.textBox_equipcountAccount.TabIndex = 219;
            // 
            // label_docsactAccount
            // 
            this.label_docsactAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_docsactAccount.AutoSize = true;
            this.label_docsactAccount.BackColor = System.Drawing.SystemColors.Control;
            this.label_docsactAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_docsactAccount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_docsactAccount.Location = new System.Drawing.Point(68, 37);
            this.label_docsactAccount.Name = "label_docsactAccount";
            this.label_docsactAccount.Size = new System.Drawing.Size(120, 19);
            this.label_docsactAccount.TabIndex = 218;
            this.label_docsactAccount.Text = "Номер счета:";
            // 
            // dateTimePicker_equipcountDateval
            // 
            this.dateTimePicker_equipcountDateval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_equipcountDateval.Location = new System.Drawing.Point(1207, 31);
            this.dateTimePicker_equipcountDateval.Name = "dateTimePicker_equipcountDateval";
            this.dateTimePicker_equipcountDateval.Size = new System.Drawing.Size(196, 27);
            this.dateTimePicker_equipcountDateval.TabIndex = 217;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(1001, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 19);
            this.label3.TabIndex = 216;
            this.label3.Text = "Дата опломбирования:";
            // 
            // button_equipcountInsert
            // 
            this.button_equipcountInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_equipcountInsert.BackColor = System.Drawing.Color.Green;
            this.button_equipcountInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_equipcountInsert.ForeColor = System.Drawing.Color.White;
            this.button_equipcountInsert.Location = new System.Drawing.Point(574, 162);
            this.button_equipcountInsert.Name = "button_equipcountInsert";
            this.button_equipcountInsert.Size = new System.Drawing.Size(146, 36);
            this.button_equipcountInsert.TabIndex = 213;
            this.button_equipcountInsert.Text = "Внести";
            this.button_equipcountInsert.UseVisualStyleBackColor = false;
            this.button_equipcountInsert.Click += new System.EventHandler(this.button_equipcountInsert_Click);
            // 
            // button_equipcountClear
            // 
            this.button_equipcountClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_equipcountClear.BackColor = System.Drawing.Color.Red;
            this.button_equipcountClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_equipcountClear.ForeColor = System.Drawing.Color.White;
            this.button_equipcountClear.Location = new System.Drawing.Point(726, 162);
            this.button_equipcountClear.Name = "button_equipcountClear";
            this.button_equipcountClear.Size = new System.Drawing.Size(146, 36);
            this.button_equipcountClear.TabIndex = 208;
            this.button_equipcountClear.Text = "Очистить";
            this.button_equipcountClear.UseVisualStyleBackColor = false;
            this.button_equipcountClear.Click += new System.EventHandler(this.button_equipcountClear_Click);
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
            // EquipmentCountersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 580);
            this.Controls.Add(this.panel_ManageAbntBottom);
            this.Controls.Add(this.DataGridView_equipmentCounters);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EquipmentCountersForm";
            this.Text = "EquipmentCountersForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_equipmentCounters)).EndInit();
            this.panel_ManageAbntBottom.ResumeLayout(false);
            this.panel_ManageAbntBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_equipcountSearch;
        private System.Windows.Forms.TextBox textBox_equipcountSearch;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_equipmentCounters;
        private System.Windows.Forms.Panel panel_ManageAbntBottom;
        private System.Windows.Forms.TextBox textBox_equipcountModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_equipcountAccount;
        private System.Windows.Forms.Label label_docsactAccount;
        private System.Windows.Forms.DateTimePicker dateTimePicker_equipcountDateval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_equipcountInsert;
        private System.Windows.Forms.Button button_equipcountClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_equipcountLocation;
        private System.Windows.Forms.Label label2;
    }
}