using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace ThesisMain
{
    public partial class LoginForm : Form
    {

        AbntClass abnt = new AbntClass();


        public LoginForm()
        {
            InitializeComponent();
        }

        public void Login()
        {
            string uname = TextBox_login.Text;
            string password = textBox_loginpassword.Text;

            if (string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(password) )
            {
                MessageBox.Show("Пожалуйста, введите данные", "Пожалуйста, введите данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable table = abnt.getlist(new MySqlCommand("SELECT * FROM `user` WHERE `username` = '" + uname + "' AND `password` = '" + password + "'"));

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Введённое имя или пароль не существуют", "Пожалуйста, введите корректные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string role = table.Rows[0]["role"].ToString();
            Program.UserRole = role;

            Form1 mainform = new Form1();
            this.Hide();
            mainform.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.ForeColor = Color.Red;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor = Color.Transparent;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Login();
        }

        

    }

}
