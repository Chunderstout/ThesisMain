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
    public partial class TransactionsForm : Form
    {

        Transactions transaction = new Transactions();

        public TransactionsForm()
        {
            InitializeComponent();
            loaddata();


            if (Program.UserRole == "user")
            {
                button_transactionsInsert.Enabled = false;
                button_transactionsInsert.BackColor = Color.LightGray;
            }

            string[] items = { "1", "2", "3" };
           comboBox_transactionsType.Items.AddRange(items);
        }

        public void loaddata()
        {
            DataTable table = transaction.GetTransaction();
            DataGridView_transactions.DataSource = table;

            DataGridView_transactions.Columns[0].HeaderText = "ID платежа";
            DataGridView_transactions.Columns[1].HeaderText = "Номер счета";
            DataGridView_transactions.Columns[2].HeaderText = "Режим потребления";
            DataGridView_transactions.Columns[3].HeaderText = "Финальная сумма";
            DataGridView_transactions.Columns[4].HeaderText = "Платеж абонента";
            DataGridView_transactions.Columns[5].HeaderText = "Статус";
            DataGridView_transactions.Columns[6].HeaderText = "Дата платежа";
            DataGridView_transactions.Columns[7].HeaderText = "Имя";
            DataGridView_transactions.Columns[8].HeaderText = "Фамилия";
            DataGridView_transactions.Columns[9].HeaderText = "Отчество";
            DataGridView_transactions.Columns[10].HeaderText = "Адрес";

        }

        private void button_transactionsInsert_Click(object sender, EventArgs e)
        {
            int accountId = int.Parse(textBox_transactionsAccount.Text);
            int rateID = int.Parse(comboBox_transactionsType.SelectedItem.ToString());
            int trpayment = int.Parse(textBox_transactionsPayment.Text);
            DateTime trdate = dateTimePicker_transactionsDate.Value;

            if (transaction.InsertTransaction(accountId, rateID, trpayment, trdate))
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

        private void button_transactionsClear_Click(object sender, EventArgs e)
        {
            textBox_transactionsAccount.Clear();
            textBox_transactionSearch.Clear();
            textBox_transactionsPayment.Clear();
            dateTimePicker_transactionsDate.Value = DateTime.Now;
        }

        private void button_transactionsSearch_Click(object sender, EventArgs e)
        {
            DataGridView_transactions.DataSource = transaction.searchTransactions(textBox_transactionSearch.Text);
        }
    }
}
