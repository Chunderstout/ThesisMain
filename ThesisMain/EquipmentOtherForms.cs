using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisMain
{
    public partial class EquipmentOtherForms : Form
    {
        EquipmentOther eqother = new EquipmentOther();

        public EquipmentOtherForms()
        {
            InitializeComponent();

            loaddata();


            if (Program.UserRole == "user")
            {
                button_equipotherInsert.Enabled = false;
                button_equipotherInsert.BackColor = Color.LightGray;
            }

            string[] items = { "Плита", "Колонка", "Отопление" };
            comboBox_equipotherType.Items.AddRange(items);
        }

        public void loaddata()
        {
            DataTable table = eqother.GetEquipmentOther();
            DataGridView_equipmentOther.DataSource = table;

            DataGridView_equipmentOther.Columns[0].HeaderText = "ID Оборудования";
            DataGridView_equipmentOther.Columns[1].HeaderText = "Номер счета";
            DataGridView_equipmentOther.Columns[2].HeaderText = "Модель";
            DataGridView_equipmentOther.Columns[3].HeaderText = "Тип";
            DataGridView_equipmentOther.Columns[4].HeaderText = "Дата установки";
            DataGridView_equipmentOther.Columns[5].HeaderText = "Имя";
            DataGridView_equipmentOther.Columns[6].HeaderText = "Фамилия";
            DataGridView_equipmentOther.Columns[7].HeaderText = "Отчество";
            DataGridView_equipmentOther.Columns[8].HeaderText = "Адрес";


        }

        private void button_equipotherInsert_Click(object sender, EventArgs e)
        {

            int accountId = int.Parse(textBox_equipotherAccount.Text);
            string eqother_model = textBox_equipotherModel.Text;
            string eqother_type = comboBox_equipotherType.SelectedItem.ToString();
            DateTime eqother_date = dateTimePicker_equipotherDate.Value;

            if (eqother.InsertEquipmentOther(accountId, eqother_model, eqother_type, eqother_date))
            {
                MessageBox.Show("Оборудование внесено успешно", "Внесение Оборудования", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
            }
            else
            {
                MessageBox.Show("Номер счета не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loaddata();
            }
        }

        private void button_equipotherClear_Click(object sender, EventArgs e)
        {
            textBox_equipotherAccount.Clear();
            textBox_equipotherModel.Clear();
            textBox_equipotherSearch.Clear();
            dateTimePicker_equipotherDate.Value = DateTime.Now;
        }

        private void button_equipotherSearch_Click(object sender, EventArgs e)
        {
            DataGridView_equipmentOther.DataSource = eqother.searchEquipmentOther(textBox_equipotherSearch.Text);
        }
    }
}
