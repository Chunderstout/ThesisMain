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
    public partial class DocRequestForm : Form
    {

        DocumentsRequest docreq = new DocumentsRequest();

        public DocRequestForm()
        {
            InitializeComponent();
            loaddata();


            if (Program.UserRole == "user")
            {
                button_docsreqInsert.Enabled = false;
                button_docsreqInsert.BackColor = Color.LightGray;
            }
        }

        public void loaddata()
        {
            DataTable table = docreq.GetDocumentRequest();
            DataGridView_DocsRequest.DataSource = table;

            DataGridView_DocsRequest.Columns[0].HeaderText = "Номер Заявки";
            DataGridView_DocsRequest.Columns[1].HeaderText = "ID счета";
            DataGridView_DocsRequest.Columns[2].HeaderText = "Оборудование";
            DataGridView_DocsRequest.Columns[3].HeaderText = "Дата заключения";
            DataGridView_DocsRequest.Columns[4].HeaderText = "Фамилия";
            DataGridView_DocsRequest.Columns[5].HeaderText = "Имя";
            DataGridView_DocsRequest.Columns[6].HeaderText = "Отчество";
            DataGridView_DocsRequest.Columns[7].HeaderText = "Адрес";


        }

        private void button_docsreqInsert_Click(object sender, EventArgs e)
        {
            int account = int.Parse(textBox_docsreqAccount.Text);
            string eqmodel = textBox_docsreqEqmodel.Text;
            DateTime contractdate = dateTimePicker_docsreqDate.Value;

            if (docreq.InsertRequest(account, eqmodel, contractdate))
            {
                MessageBox.Show("Заявка внесена успешно", "Внесение Заявки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
            }
            else
            {
                MessageBox.Show("Номер счета не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loaddata();
            }
        }

        private void button_docsreqSearch_Click(object sender, EventArgs e)
        {
            DataGridView_DocsRequest.DataSource = docreq.SearchRequest(textBox_docsreqSearch.Text);

            //ПОЧЕМУ ОНИ ВЫВОДЯТСЯ В ОЧЕНЬ СТРАННОМ ПОРЯДКЕ? ЧТО?

            DataGridView_DocsRequest.Columns[0].HeaderText = "Номер Заявки";
            DataGridView_DocsRequest.Columns[1].HeaderText = "ID счета";
            DataGridView_DocsRequest.Columns[2].HeaderText = "Оборудование";
            DataGridView_DocsRequest.Columns[3].HeaderText = "Дата заключения";
            DataGridView_DocsRequest.Columns[4].HeaderText = "Номер счета";
            DataGridView_DocsRequest.Columns[5].HeaderText = "Имя";
            DataGridView_DocsRequest.Columns[6].HeaderText = "Фамилия";
            DataGridView_DocsRequest.Columns[7].HeaderText = "Отчество";
            DataGridView_DocsRequest.Columns[8].HeaderText = "Адрес";
        }

        private void button_docsreqClear_Click(object sender, EventArgs e)
        {
            textBox_docsreqAccount.Clear();
            textBox_docsreqEqmodel.Clear();
            dateTimePicker_docsreqDate.Value = DateTime.Now;
        }
    }
}
