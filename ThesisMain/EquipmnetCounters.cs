using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisMain
{
    internal class EquipmnetCounters
    {
        DBconnect connect = new DBconnect();

        public DataTable GetEquipmentCounter()
        {
            string query = "SELECT c.counter_id, c.counter_model, c.account_id, c.counter_dateval, c.counter_datenextcheck, c.counter_location, a.abnt_firstname, a.abnt_middlename, a.abnt_lastname, a.abnt_adress FROM equipmentcounter c INNER JOIN abonent a ON c.account_id = a.account_id;";
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool InsertCounter(string countmodel, int accountId, DateTime countdateval, DateTime countdatenext, string countlocation)
        {

            connect.openConnect();

            string checkCounterQuery = "SELECT COUNT(*) FROM equipmentcounter WHERE account_id = @accId";
            MySqlCommand checkContractCommand = new MySqlCommand(checkCounterQuery, connect.GetConnection);
            checkContractCommand.Parameters.AddWithValue("@accId", accountId);
            int counterCount = Convert.ToInt32(checkContractCommand.ExecuteScalar());

            if (counterCount > 0)
            {
                MessageBox.Show("Счетчик для данного пользователя уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string insertCounterQuery = "INSERT INTO equipmentcounter (counter_model, account_id, counter_dateval, counter_datenextcheck, counter_location) VALUES ( @countmod, @accId, @cdateval, @cdatenxt, @clocat)";
            MySqlCommand insertActCommand = new MySqlCommand(insertCounterQuery, connect.GetConnection);
            insertActCommand.Parameters.AddWithValue("@countmod", countmodel);
            insertActCommand.Parameters.AddWithValue("@accId", accountId);
            insertActCommand.Parameters.AddWithValue("@cdateval", countdateval);
            insertActCommand.Parameters.AddWithValue("@cdatenxt", countdatenext);
            insertActCommand.Parameters.AddWithValue("@clocat", countlocation);

            int rowsAffected = insertActCommand.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DataTable searchcounter(string searchdata)
        {
            string query = "SELECT ec.counter_id, ec.counter_model, ec.account_id, ec.counter_dateval, ec.counter_datenextcheck, ec.counter_location, a.account_number, ab.abnt_firstname, ab.abnt_middlename, ab.abnt_lastname, ab.abnt_adress " +
                            "FROM equipmentcounter ec " +
                            "JOIN account a ON ec.account_id = a.account_id " +
                            "JOIN abonent ab ON a.account_id = ab.account_id " +
                            "WHERE CONCAT(ab.abnt_firstname, ' ', ab.abnt_middlename, ' ', ab.abnt_lastname, ' ', ab.abnt_adress, ' ', CAST(ec.counter_id AS CHAR)) LIKE '%" + searchdata + "%'";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }

}
