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
    public partial class ManageAbntForm : Form
    {

        AbntClass abonent = new AbntClass();

        public ManageAbntForm()
        {
            InitializeComponent();

            if (Program.UserRole == "user")
            {
                button_AbntManageDelete.Enabled = false;
                button_AbntManageDelete.BackColor = Color.LightGray;

                button_AbntManageUpdate.Enabled = false;
                button_AbntManageUpdate.BackColor = Color.LightGray;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel_ManageAbntBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageAbntForm_Load(object sender, EventArgs e)
        {
            showtable();
        }

        public void showtable()
        {
            DataGridView1_ManageAbmt.DataSource = abonent.getAbonentList();
            DataGridView1_ManageAbmt.RowTemplate.Height = 80;

            DataGridView1_ManageAbmt.Columns[0].HeaderText = "ID";
            DataGridView1_ManageAbmt.Columns[1].HeaderText = "Номер счета";
            DataGridView1_ManageAbmt.Columns[2].HeaderText = "Имя";
            DataGridView1_ManageAbmt.Columns[3].HeaderText = "Фамилия";
            DataGridView1_ManageAbmt.Columns[4].HeaderText = "Отчество";
            DataGridView1_ManageAbmt.Columns[5].HeaderText = "Дата рождения";
            DataGridView1_ManageAbmt.Columns[6].HeaderText = "Пол";
            DataGridView1_ManageAbmt.Columns[7].HeaderText = "Адрес";
            DataGridView1_ManageAbmt.Columns[8].HeaderText = "Серия паспорта";
            DataGridView1_ManageAbmt.Columns[9].HeaderText = "Номер паспорта";
            DataGridView1_ManageAbmt.Columns[10].HeaderText = "Кем выдан";
            DataGridView1_ManageAbmt.Columns[11].HeaderText = "Телефон";
            DataGridView1_ManageAbmt.Columns[12].HeaderText = "e-mail";
            DataGridView1_ManageAbmt.Columns[13].HeaderText = "кол-во проживающих";
            DataGridView1_ManageAbmt.Columns[14].HeaderText = "Площадь";
            DataGridView1_ManageAbmt.Columns[15].Visible = false;
        }



        private void DataGridView1_ManageAbmt_Click(object sender, EventArgs e)
        {
            textBox_AbntMngAccount.Text = DataGridView1_ManageAbmt.CurrentRow.Cells[1].Value.ToString(); 
            textBox_AbntMngFirstname.Text = DataGridView1_ManageAbmt.CurrentRow.Cells[2].Value.ToString();
            textBox_AbntMngMiddlename.Text = DataGridView1_ManageAbmt.CurrentRow.Cells[3].Value.ToString();
            textBox_AbntMngLastname.Text = DataGridView1_ManageAbmt.CurrentRow.Cells[4].Value.ToString();

            dateTimePicker_AbntMngDatebirth.Value = (DateTime)DataGridView1_ManageAbmt.CurrentRow.Cells[5].Value;

            if (DataGridView1_ManageAbmt.CurrentRow.Cells[6].Value.ToString() == "Муж")
                radioButton_AbntMngMale.Checked = true;

            textBox_AbntMngAdress.Text = DataGridView1_ManageAbmt.CurrentRow.Cells[7].Value.ToString();
            textBox_AbntMngPassseries.Text = DataGridView1_ManageAbmt.CurrentRow.Cells[8].Value.ToString();
            textBox_AbntMngPassnumber.Text = DataGridView1_ManageAbmt.CurrentRow.Cells[9].Value.ToString();
            textBox_AbntMngIssue.Text = DataGridView1_ManageAbmt.CurrentRow.Cells[10].Value.ToString();
            textBox_AbntMngPhonenumber.Text = DataGridView1_ManageAbmt.CurrentRow.Cells[11].Value.ToString();
            textBox_AbntMngEmail.Text = DataGridView1_ManageAbmt.CurrentRow.Cells[12].Value.ToString();
            textBox_AbntMngNumpeople.Text = DataGridView1_ManageAbmt.CurrentRow.Cells[13].Value.ToString();
            textBox_AbntMngSquare.Text = DataGridView1_ManageAbmt.CurrentRow.Cells[14].Value.ToString();
            textBox_AbntMnggasconsumption.Text = DataGridView1_ManageAbmt.CurrentRow.Cells[15].Value.ToString();

        }

        private void button_AbntManageClear_Click_1(object sender, EventArgs e)
        {
            textBox_AbntMngAccount.Clear();
            textBox_AbntMngFirstname.Clear();
            textBox_AbntMngMiddlename.Clear();
            textBox_AbntMngLastname.Clear();
            textBox_AbntMngAdress.Clear();
            textBox_AbntMngPassseries.Clear();
            textBox_AbntMngPassnumber.Clear();
            textBox_AbntMngIssue.Clear();
            textBox_AbntMngPhonenumber.Clear();
            textBox_AbntMngEmail.Clear();
            textBox_AbntMngNumpeople.Clear();
            textBox_AbntMngSquare.Clear();
            textBox_AbntMnggasconsumption.Clear();

            dateTimePicker_AbntMngDatebirth.Value = DateTime.Now;
            radioButton_AbntMngMale.Checked = true;

        }

        private void button_AbntMngSearch_Click(object sender, EventArgs e)
        {
            DataGridView1_ManageAbmt.DataSource = abonent.searchabonent(textBox_AbntMngSearch.Text);
        }
        
        private void button_AbntManageUpdate_Click(object sender, EventArgs e)
        {
            string accountNumber = textBox_AbntMngAccount.Text;
            string fname = textBox_AbntMngFirstname.Text;
            string mname = textBox_AbntMngMiddlename.Text;
            string lname = textBox_AbntMngLastname.Text;
            DateTime bdate = dateTimePicker_AbntMngDatebirth.Value;
            string phone = textBox_AbntMngPhonenumber.Text;
            string email = textBox_AbntMngEmail.Text;
            string adress = textBox_AbntMngAdress.Text;
            string passer = textBox_AbntMngPassseries.Text;
            string passnum = textBox_AbntMngPassnumber.Text;
            string passiss = textBox_AbntMngIssue.Text;
            string numres = textBox_AbntMngNumpeople.Text;
            string propsqr = textBox_AbntMngSquare.Text;
            string gascons = textBox_AbntMnggasconsumption.Text;

            string gender = radioButton_AbntMngMale.Checked ? "Муж" : "Жен";

            // BIRTH DATE CHECK

            int birth_year = dateTimePicker_AbntMngDatebirth.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - birth_year) < 18 || (this_year - birth_year) > 110)
            {
                MessageBox.Show("Значение возраста должно быть между 18 и 110", "Введён некорректный возраст", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    if (abonent.updateabonent(accountNumber, fname, mname, lname, bdate, gender, adress, passer, passnum, passiss, phone, email, numres, propsqr, gascons))
                    {
                        showtable();
                        MessageBox.Show("Обновление данных абонента", "Обновление абонента", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пустое поле", "Обновление абонента", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool verify()
        {
            if ((textBox_AbntMngFirstname.Text == "") || (textBox_AbntMngMiddlename.Text == "") || (textBox_AbntMngLastname.Text == "") ||
                (textBox_AbntMngAdress.Text == "") || (textBox_AbntMngPassseries.Text == "") || (textBox_AbntMngPassnumber.Text == "") ||
                (textBox_AbntMngIssue.Text == "") || (textBox_AbntMngPhonenumber.Text == "") || (textBox_AbntMngNumpeople.Text == "") ||
                (textBox_AbntMngEmail.Text == "") || (textBox_AbntMngSquare.Text == "") || (textBox_AbntMnggasconsumption.Text == ""))

            {
                return false;
            }
            else
                return true;
        }

        private void button_AbntManageDelete_Click(object sender, EventArgs e)
        {
            int accountId = Convert.ToInt32(DataGridView1_ManageAbmt.SelectedRows[0].Cells["account_id"].Value);

            AbntClass abonent = new AbntClass();
            bool success = abonent.DeleteAbonent(accountId);

            if (success)
            {
                MessageBox.Show("Абонент успешно удалён");
                showtable();
            }
            else
            {
                MessageBox.Show("Не удалось удалить Абонента. Есть связанные данные.");
            }
        }
    }
}
