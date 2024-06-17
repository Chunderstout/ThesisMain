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
    public partial class Form1 : Form
    {   

        AbntClass abonent = new AbntClass();

        public Form1()
        {
            InitializeComponent();
            CustomDesign();

            string role = Program.UserRole;
            label_user.Text = $"Добро пожаловать, {role}";

            if (Program.UserRole == "user")
            {
                button_abntRegister.Enabled = false;
                button_abntRegister.BackColor = Color.LightGray;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_totalabntcount.Text = abonent.totalAbonent();
        }

        private void CustomDesign()
        {
            panel_abntsubmenu.Visible = false;
            panel_docssubmenu.Visible = false;
            panel_transsubmenu.Visible = false;
            panel_equipsubmenu.Visible = false;
        }

        private void HideSubmenu()
        {
            if (panel_abntsubmenu.Visible == true)
                panel_abntsubmenu.Visible = false;
            if (panel_docssubmenu.Visible == true)
                panel_docssubmenu.Visible = false;
            if (panel_transsubmenu.Visible == true)
                panel_transsubmenu.Visible = false;
            if (panel_equipsubmenu.Visible == true)
                panel_equipsubmenu.Visible = false;
        }

        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;

        }

        private void button_abnt_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panel_abntsubmenu);
        }

        #region abntsubmenu

        private void button_abntRegister_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            //...
            //... code goes here
            //
            HideSubmenu();
        }

        private void button_abntManage_Click(object sender, EventArgs e)
        {
            openChildForm( new ManageAbntForm());
            //...
            //... code goes here
            //
            HideSubmenu();
        }

        private void button_abntStatus_Click(object sender, EventArgs e)
        {
            //...
            //... code goes here
            //
            HideSubmenu();
        }

        private void button_abntPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintAbonentForm());
            //...
            //... code goes here
            //
            HideSubmenu();
        }

        #endregion

        private void button_docs_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panel_docssubmenu);
        }

        #region docssubmenu

        private void button_docsActs_Click(object sender, EventArgs e)
        {
            openChildForm(new DocActForm());
            //...
            //... code goes here
            //
            HideSubmenu();
        }

        private void button_docsRequests_Click(object sender, EventArgs e)
        {
            openChildForm(new DocRequestForm());
            //...
            //... code goes here
            //
            HideSubmenu();
        }

        private void button_docsContracts_Click(object sender, EventArgs e)
        {
            openChildForm(new DocContractForm());
            //...
            //... code goes here
            //
            HideSubmenu();
        }

        private void button_docsPrint_Click(object sender, EventArgs e)
        {
            //...
            //... code goes here
            //
            HideSubmenu();
        }


        #endregion

        private void button_trans_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panel_transsubmenu);
        }

        #region transsubmenu
        private void button_transManage_Click(object sender, EventArgs e)
        {
            openChildForm(new TransactionsForm());
            //...
            //... code goes here
            //
            HideSubmenu();
        }

        private void button_transAdd_Click(object sender, EventArgs e)
        {
            //...
            //... code goes here
            //
            HideSubmenu();
        }

        private void button_transPrint_Click(object sender, EventArgs e)
        {
            //...
            //... code goes here
            //
            HideSubmenu();
        }



        #endregion

        private void button_equip_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panel_equipsubmenu);
        }

        #region equipsubmenu
        private void button_equipManage_Click(object sender, EventArgs e)
        {
            openChildForm(new EquipmentOtherForms());
            //...
            //... code goes here
            //
            HideSubmenu();
        }

        private void button_equipCounters_Click(object sender, EventArgs e)
        {
            openChildForm(new EquipmentCountersForm());
            //...
            //... code goes here
            //
            HideSubmenu();
        }

        private void button_equipPrint_Click(object sender, EventArgs e)
        {
            //...
            //... code goes here
            //
            HideSubmenu();
        }

        #endregion

        private void label_totalabntcount_Click(object sender, EventArgs e)
        {

        }

        //SHOW REGISTER FORM

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


            //костыль но пока так

            panelsHide();

        }

        public void panelsHide()
        {
            if (panel_roleheader.Visible == true)
                panel_roleheader.Visible = false;
            if (panel_header.Visible == true)
                panel_header.Visible = false;
            if (panel_bottom.Visible == true)
                panel_bottom.Visible = false;
        }

        public void panelsShow()
        {
            if (panel_roleheader.Visible == false)
                panel_roleheader.Visible = true;
            if (panel_header.Visible == false)
                panel_header.Visible = true;
            if (panel_bottom.Visible == false)
                panel_bottom.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button_backtomain_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panelsShow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
