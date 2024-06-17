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
    public partial class DocContractForm : Form
    {

        DocumentsContract doccontract = new DocumentsContract();

        public DocContractForm()
        {
            InitializeComponent();
            loaddata();


            if (Program.UserRole == "user")
            {
                button_docscontrtInsert.Enabled = false;
                button_docscontrtInsert.BackColor = Color.LightGray;
            }

        }

        public void loaddata()
        {
            DataTable table = doccontract.GetDocumentContract();
            DataGridView_DocsContract.DataSource = table;

            DataGridView_DocsContract.Columns[0].HeaderText = "Номер Договора";
            DataGridView_DocsContract.Columns[1].HeaderText = "ID счета";
            DataGridView_DocsContract.Columns[2].HeaderText = "Дата заключения";
            DataGridView_DocsContract.Columns[3].HeaderText = "Фамилия";
            DataGridView_DocsContract.Columns[4].HeaderText = "Имя";
            DataGridView_DocsContract.Columns[5].HeaderText = "Отчество";
            DataGridView_DocsContract.Columns[6].HeaderText = "Адрес";


        }

        private void button_docscontrtInsert_Click(object sender, EventArgs e)
        {
            int account = int.Parse(textBox_docscontrAccount.Text);
            DateTime contractdate = dateTimePicker_docscontrDate.Value;

            if (doccontract.Insertcontract(account, contractdate))
            {
                MessageBox.Show("Договор внесён успешно", "Внесение Договора", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
            }
            else
            {
                MessageBox.Show("Номер счета не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loaddata();
            }
        }

        private void button_docscontrtSearch_Click(object sender, EventArgs e)
        {
            DataGridView_DocsContract.DataSource = doccontract.searchcontract(textBox_docscontrSearch.Text);

            DataGridView_DocsContract.Columns[0].HeaderText = "Номер Договора";
            DataGridView_DocsContract.Columns[1].HeaderText = "ID счета";
            DataGridView_DocsContract.Columns[2].HeaderText = "Дата заключения";
            DataGridView_DocsContract.Columns[3].HeaderText = "Номер счета";
            DataGridView_DocsContract.Columns[4].HeaderText = "Имя";
            DataGridView_DocsContract.Columns[5].HeaderText = "Отчество";
            DataGridView_DocsContract.Columns[6].HeaderText = "Фамилия";

        }

        private void button_docscontrClear_Click(object sender, EventArgs e)
        {
            textBox_docscontrAccount.Clear();
            textBox_docscontrSearch.Clear();
            dateTimePicker_docscontrDate.Value = DateTime.Now;
        }
    }
}
