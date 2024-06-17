using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ThesisMain
{
    internal class AbntClass
    {
        DBconnect connect = new DBconnect();

        // FUCNTION FOR ADDING NEW ABONENTS

        public bool insertabonent(string fname, string mname, string lname, DateTime bdate, string gender, string adress, string passer, string passnum, string passiss, string phone, string email, string numres, string propsqr, string gascons)
        {
            Random rand = new Random();
            int accountNumber = rand.Next(Int32.MinValue, Int32.MaxValue);

            // Check if the account number already exists in the account table
            MySqlCommand commandCheck = new MySqlCommand("SELECT COUNT(*) FROM `account` WHERE `account_number` = @accountNumber", connect.GetConnection);
            commandCheck.Parameters.Add("@accountNumber", MySqlDbType.VarChar).Value = accountNumber;

            connect.openConnect();
            int count = Convert.ToInt32(commandCheck.ExecuteScalar());
            connect.closeConnect();

            if (count > 0)
            {
                // The account number already exists, so generate a new one and try again
                return insertabonent(fname, mname, lname, bdate, gender, adress, passer, passnum, passiss, phone, email, numres, propsqr, gascons);
            }
            else
            {
                // Insert a new record into the account table with the randomly generated account number
                MySqlCommand commandAccount = new MySqlCommand("INSERT INTO `account`(`account_number`) VALUES (@accountNumber)", connect.GetConnection);
                commandAccount.Parameters.Add("@accountNumber", MySqlDbType.VarChar).Value = accountNumber;

                connect.openConnect();
                commandAccount.ExecuteNonQuery();
                int accountId = (int)commandAccount.LastInsertedId;
                connect.closeConnect();

                // Insert a new record into the abonent table with the account_id value from the account table
                MySqlCommand command = new MySqlCommand("INSERT INTO `abonent`(`account_id`, `abnt_firstname`, `abnt_middlename`, `abnt_lastname`, `abnt_datebirth`, `abnt_gender`, `abnt_adress`, `adnt_passeries`, `abnt_passnumber`, `abnt_passissue`, `abnt_phonenumber`, `abnt_email`, `abnt_numresidents`, `abnt_propertysqr`, `abnt_gasconsumption`) VALUES (@accountId, @fn,@mn,@ln,@db,@gd,@adr,@psr,@psn,@psi,@ph,@em,@nur,@sqr,@gas)", connect.GetConnection);

                command.Parameters.Add("@accountId", MySqlDbType.Int32).Value = accountId;
                command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
                command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@db", MySqlDbType.Date).Value = bdate;
                command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = adress;
                command.Parameters.Add("@psr", MySqlDbType.VarChar).Value = passer;
                command.Parameters.Add("@psn", MySqlDbType.VarChar).Value = passnum;
                command.Parameters.Add("@psi", MySqlDbType.VarChar).Value = passiss;
                command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
                command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email;
                command.Parameters.Add("@nur", MySqlDbType.VarChar).Value = numres;
                command.Parameters.Add("@sqr", MySqlDbType.VarChar).Value = propsqr;
                command.Parameters.Add("@gas", MySqlDbType.VarChar).Value = gascons;

                connect.openConnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    connect.closeConnect();
                    return true;
                }
                else
                {
                    connect.closeConnect();
                    return false;
                }
            }
        }


        // Get Abonent List
        public DataTable getAbonentList()
        {
            MySqlCommand command = new MySqlCommand("SELECT a.account_id, a.account_number, b.abnt_firstname, b.abnt_middlename, b.abnt_lastname, b.abnt_datebirth, b.abnt_gender, b.abnt_adress, b.adnt_passeries, b.abnt_passnumber, b.abnt_passissue, b.abnt_phonenumber, b.abnt_email, b.abnt_numresidents, b.abnt_propertysqr, b.abnt_gasconsumption FROM account a INNER JOIN abonent b ON a.account_id = b.account_id", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Abonent Count (Total)
        public string executeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }

        // Get Total Abonent Count
        public string totalAbonent()
        {
            return executeCount("SELECT COUNT(*) FROM abonent");
        }

        // Search for Abonent
        public DataTable searchabonent(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT a.account_id, a.account_number, b.abnt_firstname, b.abnt_middlename, b.abnt_lastname, b.abnt_datebirth, b.abnt_gender, b.abnt_adress, b.adnt_passeries, b.abnt_passnumber, b.abnt_passissue, b.abnt_phonenumber, b.abnt_email, b.abnt_numresidents, b.abnt_propertysqr, b.abnt_gasconsumption FROM account a INNER JOIN abonent b ON a.account_id = b.account_id WHERE CONCAT(a.account_number, b.abnt_firstname, b.abnt_middlename, b.abnt_lastname, b.abnt_adress) LIKE '%" + searchdata + "%'", connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // UPDATE EXISTING ABONENT FUNCTION

        public bool updateabonent(string accountNumber, string fname, string mname, string lname, DateTime bdate, string gender, string adress, string passer, string passnum, string passiss, string phone, string email, string numres, string propsqr, string gascons)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `abonent` INNER JOIN `account` ON `abonent`.`account_id` = `account`.`account_id` SET `abnt_firstname`=@fn, `abnt_middlename`=@mn, `abnt_lastname`=@ln, `abnt_datebirth`=@db, `abnt_gender`=@gd, `abnt_adress`=@adr, `adnt_passeries`=@psr, `abnt_passnumber`=@psn, `abnt_passissue`=@psi, `abnt_phonenumber`=@ph, `abnt_email`=@em, `abnt_numresidents`=@nur, `abnt_propertysqr`=@sqr, `abnt_gasconsumption`=@gas WHERE `account`.`account_number` = @acc", connect.GetConnection);

            command.Parameters.Add("@acc", MySqlDbType.VarChar).Value = accountNumber;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@db", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;  
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = adress;
            command.Parameters.Add("@psr", MySqlDbType.VarChar).Value = passer;
            command.Parameters.Add("@psn", MySqlDbType.VarChar).Value = passnum;
            command.Parameters.Add("@psi", MySqlDbType.VarChar).Value = passiss;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@nur", MySqlDbType.VarChar).Value = numres;
            command.Parameters.Add("@sqr", MySqlDbType.VarChar).Value = propsqr;
            command.Parameters.Add("@gas", MySqlDbType.VarChar).Value = gascons;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        //TO DELETE ABONENT

        public bool DeleteAbonent(int accountId)
        {
           
            {
                connect.openConnect();

                // Check if the abonent has any associated acts
                string checkActsQuery = "SELECT COUNT(*) FROM documentact WHERE account_id = @accountId";
                MySqlCommand checkActsCommand = new MySqlCommand(checkActsQuery, connect.GetConnection);
                checkActsCommand.Parameters.AddWithValue("@accountId", accountId);
                int actsCount = Convert.ToInt32(checkActsCommand.ExecuteScalar());

                if (actsCount > 0)
                {
                    // Abonent has associated acts, cannot delete
                    return false;
                }

                // Delete the abonent from the database
                string deleteQuery = "DELETE FROM abonent WHERE account_id = @accountId";
                MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connect.GetConnection);
                deleteCommand.Parameters.AddWithValue("@accountId", accountId);
                int rowsAffected = deleteCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Abonent deleted successfully
                    return true;
                }
                else
                {
                    // Failed to delete abonent
                    return false;
                }
            }
        }

        public DataTable getlist(MySqlCommand command)
        {
            command.Connection = connect.GetConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


    }
}
