using MySql.Data.MySqlClient;
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
    public partial class PrintAbonentForm : Form
    {

        AbntClass abonent = new AbntClass();

        public PrintAbonentForm()
        {
            InitializeComponent();

            // ПОЧЕМУ ТУТ РАБОТАЕТ А В Form_Load НЕ РАБОТАЕТ???

            showData(new MySqlCommand("SELECT * FROM `abonent`"));
        }

        private void PrintAbonentForm_Load(object sender, EventArgs e)
        {
            //showData(new MySqlCommand("SELECT * FROM `abonent`"));
        }

        public void showData(MySqlCommand command)
        {
            DataGridView1_PrintAbmt.DataSource = abonent.getlist(command);
            DataGridView1_PrintAbmt.RowTemplate.Height = 80;

            DataGridView1_PrintAbmt.Columns[0].HeaderText = "Номер счета";
            DataGridView1_PrintAbmt.Columns[1].HeaderText = "Имя";
            DataGridView1_PrintAbmt.Columns[2].HeaderText = "Фамилия";
            DataGridView1_PrintAbmt.Columns[3].HeaderText = "Отчество";
            DataGridView1_PrintAbmt.Columns[4].HeaderText = "Дата рождения";
            DataGridView1_PrintAbmt.Columns[5].HeaderText = "Пол";
            DataGridView1_PrintAbmt.Columns[6].HeaderText = "Адрес";
            DataGridView1_PrintAbmt.Columns[7].HeaderText = "Серия паспорта";
            DataGridView1_PrintAbmt.Columns[8].HeaderText = "Номер паспорта";
            DataGridView1_PrintAbmt.Columns[9].HeaderText = "Кем выдан";
            DataGridView1_PrintAbmt.Columns[10].HeaderText = "Телефон";
            DataGridView1_PrintAbmt.Columns[11].HeaderText = "e-mail";
            DataGridView1_PrintAbmt.Columns[12].HeaderText = "кол-во проживающих";
            DataGridView1_PrintAbmt.Columns[13].HeaderText = "Площадь";
            DataGridView1_PrintAbmt.Columns[14].HeaderText = "Газопотребление";
        }


    }
}
