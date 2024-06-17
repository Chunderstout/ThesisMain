using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ThesisMain
{
    public partial class RegisterForm : Form
    {

        AbntClass abonent = new AbntClass();

        public RegisterForm()
        {
            InitializeComponent();

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showtable();
        }

        // ABONENT LIST DISPLAY

        public void showtable()
        {
            DataGridView1_regAbmt.DataSource = abonent.getAbonentList();
            DataGridView1_regAbmt.RowTemplate.Height = 80;

            DataGridView1_regAbmt.Columns[0].HeaderText = "ID";
            DataGridView1_regAbmt.Columns[1].HeaderText = "Номер счета";
            DataGridView1_regAbmt.Columns[2].HeaderText = "Имя";
            DataGridView1_regAbmt.Columns[3].HeaderText = "Фамилия";
            DataGridView1_regAbmt.Columns[4].HeaderText = "Отчество";
            DataGridView1_regAbmt.Columns[5].HeaderText = "Дата рождения";
            DataGridView1_regAbmt.Columns[6].HeaderText = "Пол";
            DataGridView1_regAbmt.Columns[7].HeaderText = "Адрес";
            DataGridView1_regAbmt.Columns[8].HeaderText = "Серия паспорта";
            DataGridView1_regAbmt.Columns[9].HeaderText = "Номер паспорта";
            DataGridView1_regAbmt.Columns[10].HeaderText = "Кем выдан";
            DataGridView1_regAbmt.Columns[11].HeaderText = "Телефон";
            DataGridView1_regAbmt.Columns[12].HeaderText = "e-mail";
            DataGridView1_regAbmt.Columns[13].HeaderText = "кол-во проживающих";
            DataGridView1_regAbmt.Columns[14].HeaderText = "Площадь";
            DataGridView1_regAbmt.Columns[15].Visible = false;
        }


        //=========================================== ADD ABONENT =================================================

        private void button_regCommit_Click(object sender, EventArgs e)
        {

        }


        //======================================= VERIFY IF EMPTY =====================================================
        bool verify()
        {
            if ((textBox_regFirstname.Text == "") || (textBox_regMiddlename.Text == "") || (textBox_regLastname.Text == "") ||
                (textBox_regAdress.Text == "") || (textBox_regPassseries.Text == "") || (textBox_regPassnumber.Text == "") ||
                (textBox_regIssue.Text == "") || (textBox_regPhonenumber.Text == "") || (textBox_regNumpeople.Text == "") ||
                (textBox_regEmail.Text == "") || (textBox_regSquare.Text == "") || (textBox_reggasconsumption.Text == ""))

            {
                return false;
            }
            else
                return true;
        }


        private void button_regClear_Click(object sender, EventArgs e)
        {
            // CLEAR ALL FIELDS

            textBox_regFirstname.Clear();
            textBox_regMiddlename.Clear();
            textBox_regLastname.Clear();
            textBox_regAdress.Clear();
            textBox_regPassseries.Clear();
            textBox_regPassnumber.Clear();
            textBox_regIssue.Clear();
            textBox_regPhonenumber.Clear();
            textBox_regNumpeople.Clear();
            textBox_regEmail.Clear();
            textBox_regSquare.Clear();
            textBox_reggasconsumption.Clear();
           
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button_regCommit_Click_1(object sender, EventArgs e)
        {
            string fname = textBox_regFirstname.Text;
            string mname = textBox_regMiddlename.Text;
            string lname = textBox_regLastname.Text;
            DateTime bdate = dateTimePicker_regDatebirth.Value;
            string phone = textBox_regPhonenumber.Text;
            string email = textBox_regEmail.Text;
            string adress = textBox_regAdress.Text;
            string passer = textBox_regPassseries.Text;
            string passnum = textBox_regPassnumber.Text;
            string passiss = textBox_regIssue.Text;
            string numres = textBox_regNumpeople.Text;
            string propsqr = textBox_regSquare.Text;
            string gascons = textBox_reggasconsumption.Text;

            string gender = radioButton_regMale.Checked ? "Муж" : "Жен";

            // BIRTH DATE CHECK

            int birth_year = dateTimePicker_regDatebirth.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - birth_year) < 18 || (this_year - birth_year) > 110)
            {
                MessageBox.Show("Значение возраста должно быть между 18 и 110", "Введён некорректный возраст", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    if (abonent.insertabonent(fname, mname, lname, bdate, gender, adress, passer, passnum, passiss, phone, email, numres, propsqr, gascons))
                    {
                        showtable();
                        MessageBox.Show("Добавлен новый абонент", "Добавить абонента", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пустое поле", "Добавить абонента", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
