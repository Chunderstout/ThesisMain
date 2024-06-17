using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ThesisMain
{
    public partial class DocActForm : Form
    {

        documentsact docact = new documentsact();

        public DocActForm()
        {
            InitializeComponent();
            loaddata();


            if (Program.UserRole == "user")
            {
                button_docsactInsert.Enabled = false;
                button_docsactInsert.BackColor = Color.LightGray;
            }
        }

        private void DocActForm_Load(object sender, EventArgs e)
        {

        }

        public void loaddata()
        {
            DataTable table = docact.GetDocumentActs();
            DataGridView_DocsAct.DataSource = table;

            DataGridView_DocsAct.Columns[0].HeaderText = "Номер акта";
            DataGridView_DocsAct.Columns[1].HeaderText = "ID счета";
            DataGridView_DocsAct.Columns[2].HeaderText = "Модель оборудования";
            DataGridView_DocsAct.Columns[3].HeaderText = "Цена работ";
            DataGridView_DocsAct.Columns[4].HeaderText = "Дата проведения";
            DataGridView_DocsAct.Columns[5].HeaderText = "Имя";
            DataGridView_DocsAct.Columns[6].HeaderText = "Фамилия";
            DataGridView_DocsAct.Columns[7].HeaderText = "Отчество";
            DataGridView_DocsAct.Columns[8].HeaderText = "Адрес";
        }

        private void button_docsactInsert_Click(object sender, EventArgs e)
        {

            int account = int.Parse(textBox_docsactAccount.Text);
            string acteqmodel = textBox_docsactEquipment.Text;
            decimal actprice = decimal.Parse(textBox_docsactPrice.Text);
            DateTime actdate = dateTimePicker_docsactDate.Value;

            if (docact.InsertAct(account, acteqmodel, actprice, actdate))
            {
                MessageBox.Show("Акт внесён успешно", "Внесение акта", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Номер счета не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

            //int account = Convert.ToInt32(textBox_docsactAccount.Text);
            //int actprice = Convert.ToInt32(textBox_docsactPrice.Text);
        }

        private void button_docsactClear_Click(object sender, EventArgs e)
        {
            textBox_docsactAccount.Clear();
            textBox_docsactEquipment.Clear();
            textBox_docsactPrice.Clear();
        }

        private void button_docsactSearch_Click(object sender, EventArgs e)
        {
            DataGridView_DocsAct.DataSource = docact.searchact(textBox_docsactSearch.Text);

            DataGridView_DocsAct.Columns[0].HeaderText = "Номер акта";
            DataGridView_DocsAct.Columns[1].HeaderText = "ID счета";
            DataGridView_DocsAct.Columns[2].HeaderText = "Модель оборудования";
            DataGridView_DocsAct.Columns[3].HeaderText = "Цена работ";
            DataGridView_DocsAct.Columns[4].HeaderText = "Дата проведения";

            DataGridView_DocsAct.Columns[5].HeaderText = "Номер счета";
            DataGridView_DocsAct.Columns[6].HeaderText = "ФИО";
            DataGridView_DocsAct.Columns[7].HeaderText = "Адрес";
        }
    }
}
