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
    public partial class EquipmentCountersForm : Form
    {

        EquipmnetCounters eqcounter = new EquipmnetCounters(); 

        public EquipmentCountersForm()
        {
            InitializeComponent();
            loaddata();

            if (Program.UserRole == "user")
            {
                button_equipcountInsert.Enabled = false;
                button_equipcountInsert.BackColor = Color.LightGray;
            }
        }

        public void loaddata()
        {
            DataTable table = eqcounter.GetEquipmentCounter();
            DataGridView_equipmentCounters.DataSource = table;


            DataGridView_equipmentCounters.Columns[0].HeaderText = "ID счетчика";
            DataGridView_equipmentCounters.Columns[1].HeaderText = "Модель счетчика";
            DataGridView_equipmentCounters.Columns[2].HeaderText = "номер счета";
            DataGridView_equipmentCounters.Columns[3].HeaderText = "Дата оломбирования";
            DataGridView_equipmentCounters.Columns[4].HeaderText = "Дата след. проверки";
            DataGridView_equipmentCounters.Columns[5].HeaderText = "Расположение";
            DataGridView_equipmentCounters.Columns[6].HeaderText = "Имя";
            DataGridView_equipmentCounters.Columns[7].HeaderText = "Фамилия";
            DataGridView_equipmentCounters.Columns[8].HeaderText = "Отчество";
            DataGridView_equipmentCounters.Columns[9].HeaderText = "Адрес";


        }

        private void button_equipcountInsert_Click(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;

            string countmodel = textBox_equipcountModel.Text;
            int accountId = int.Parse(textBox_equipcountAccount.Text);
            DateTime countdateval = dateTimePicker_equipcountDateval.Value;
            DateTime countdatenext = new DateTime(currentYear, countdateval.Month, countdateval.Day);
            string countlocation = textBox_equipcountLocation.Text;

            if (eqcounter.InsertCounter(countmodel, accountId, countdateval, countdatenext, countlocation))
            {
                MessageBox.Show("Счетчик внесен успешно", "Внесение Счетчика", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
            }
            else
            {
                MessageBox.Show("Номер счета не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loaddata();
            }
        }

        private void button_equipcountClear_Click(object sender, EventArgs e)
        {
            textBox_equipcountAccount.Clear();
            textBox_equipcountLocation.Clear();
            textBox_equipcountModel.Clear();
            textBox_equipcountSearch.Clear();
            dateTimePicker_equipcountDateval.Value = DateTime.Now;
        }

        private void button_equipcountSearch_Click(object sender, EventArgs e)
        {
            DataGridView_equipmentCounters.DataSource = eqcounter.searchcounter(textBox_equipcountSearch.Text);

            //Поправить странный баг

            DataGridView_equipmentCounters.Columns[0].HeaderText = "ID счетчика";
            DataGridView_equipmentCounters.Columns[1].HeaderText = "Модель счетчика";
            DataGridView_equipmentCounters.Columns[2].HeaderText = "ID счета";
            DataGridView_equipmentCounters.Columns[3].HeaderText = "Дата оломбирования";
            DataGridView_equipmentCounters.Columns[4].HeaderText = "Дата след. проверки";
            DataGridView_equipmentCounters.Columns[5].HeaderText = "Расположение";
            DataGridView_equipmentCounters.Columns[6].HeaderText = "Имя";
            DataGridView_equipmentCounters.Columns[7].HeaderText = "Фамилия";
            DataGridView_equipmentCounters.Columns[8].HeaderText = "Отчество";
            DataGridView_equipmentCounters.Columns[9].HeaderText = "Адрес";
            DataGridView_equipmentCounters.Columns[10].HeaderText = "Номер счета";

        }
    }
}
