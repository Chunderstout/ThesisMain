using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ThesisMain
{
    internal class documentsact
    {
        DBconnect connect = new DBconnect();

        public DataTable GetDocumentActs()
        {
            string query = "SELECT d.act_id, d.account_id, d.act_eqmodel, d.act_price, d.act_date, a.abnt_firstname, a.abnt_middlename, a.abnt_lastname, a.abnt_adress FROM documentact d INNER JOIN abonent a ON d.account_id = a.account_id;";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool InsertAct(int accountId, string actEqModel, decimal actPrice, DateTime actDate)
        {
            connect.openConnect();

            string checkAccountQuery = "SELECT COUNT(*) FROM account WHERE account_id = @accId";
            MySqlCommand checkAccountCommand = new MySqlCommand(checkAccountQuery, connect.GetConnection);
            checkAccountCommand.Parameters.AddWithValue("@accId", accountId);
            int accountCount = Convert.ToInt32(checkAccountCommand.ExecuteScalar());

            if (accountCount == 0)
            {
                return false;
            }

            string insertActQuery = "INSERT INTO documentact (account_id, act_eqmodel, act_price, act_date) VALUES (@accId, @eqModel, @price, @date)";
            MySqlCommand insertActCommand = new MySqlCommand(insertActQuery, connect.GetConnection);
            insertActCommand.Parameters.AddWithValue("@accId", accountId);
            insertActCommand.Parameters.AddWithValue("@eqModel", actEqModel);
            insertActCommand.Parameters.AddWithValue("@price", actPrice);
            insertActCommand.Parameters.AddWithValue("@date", actDate);

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

        public DataTable searchact(string searchdata)
        {
            string query = "SELECT d.act_id, d.account_id, d.act_eqmodel, d.act_price, d.act_date, a.account_number, CONCAT(b.abnt_firstname, ' ', b.abnt_middlename, ' ', b.abnt_lastname) AS abonent_name, b.abnt_adress " +
                            "FROM documentact d " +
                            "INNER JOIN account a ON d.account_id = a.account_id " +
                            "INNER JOIN abonent b ON a.account_id = b.account_id " +
                            "WHERE CONCAT(a.account_number, ' ', b.abnt_firstname, ' ', b.abnt_middlename, ' ', b.abnt_lastname, ' ', b.abnt_adress, ' ', d.act_eqmodel) LIKE '%" + searchdata + "%'";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


    }
}
