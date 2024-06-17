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
    internal class Transactions
    {
        DBconnect connect = new DBconnect();

        public DataTable GetTransaction()
        {
            string query = "SELECT t.tr_id, t.account_id, t.rate_id, t.tr_totalsum, t.tr_payment, t.tr_closed, t.tr_date, a.abnt_firstname, a.abnt_middlename, a.abnt_lastname, a.abnt_adress FROM transactions t INNER JOIN abonent a ON t.account_id = a.account_id;";
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool InsertTransaction(int accountId, int rateID, int trpayment, DateTime trdate)
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

            string insertCounterQuery = "INSERT INTO transactions (account_id, rate_id, tr_payment, tr_date) VALUES (@accId, @trate, @trpay, @trdate)";
            MySqlCommand insertActCommand = new MySqlCommand(insertCounterQuery, connect.GetConnection);
            insertActCommand.Parameters.AddWithValue("@accId", accountId);
            insertActCommand.Parameters.AddWithValue("@trate", rateID);
            insertActCommand.Parameters.AddWithValue("@trpay", trpayment);
            insertActCommand.Parameters.AddWithValue("@trdate", trdate);

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

        public DataTable searchTransactions(string searchdata)
        {
            string query = "SELECT t.tr_id, t.account_id, t.rate_id, t.tr_totalsum, t.tr_payment, t.tr_closed, a.account_number, ab.abnt_firstname, ab.abnt_middlename, ab.abnt_lastname, ab.abnt_adress " +
                            "FROM transactions t " +
                            "JOIN account a ON t.account_id = a.account_id " +
                            "JOIN abonent ab ON a.account_id = ab.account_id " +
                            "WHERE CONCAT(ab.abnt_firstname, ' ', ab.abnt_middlename, ' ', ab.abnt_lastname, ' ', ab.abnt_adress, ' ', CAST(t.tr_id AS CHAR)) LIKE '%" + searchdata + "%'";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

    }
}
