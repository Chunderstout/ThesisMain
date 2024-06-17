using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisMain
{
    internal class DocumentsRequest
    {
        DBconnect connect = new DBconnect();


        public DataTable GetDocumentRequest()
        {
            string query = "SELECT r.request_id, r.account_id, r.request_eqmodel, r.request_date, a.abnt_firstname, a.abnt_middlename, a.abnt_lastname, a.abnt_adress FROM documentrequest r INNER JOIN abonent a ON r.account_id = a.account_id;";
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool InsertRequest(int accountId, string requestEqModel, DateTime actDate)
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


            string insertActQuery = "INSERT INTO documentrequest (account_id, request_eqmodel, request_date) VALUES (@accId, @eqModel, @date)";
            MySqlCommand insertActCommand = new MySqlCommand(insertActQuery, connect.GetConnection);
            insertActCommand.Parameters.AddWithValue("@accId", accountId);
            insertActCommand.Parameters.AddWithValue("@eqModel", requestEqModel);
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

        public DataTable SearchRequest(string searchData)
        {
            string query = "SELECT dr.request_id, dr.account_id, dr.request_eqmodel, dr.request_date, a.account_number, ab.abnt_firstname, ab.abnt_middlename, ab.abnt_lastname, ab.abnt_adress " +
                            "FROM documentrequest dr " +
                            "JOIN account a ON dr.account_id = a.account_id " +
                            "JOIN abonent ab ON a.account_id = ab.account_id " +
                            "WHERE CONCAT(ab.abnt_firstname, ' ', ab.abnt_middlename, ' ', ab.abnt_lastname, ' ', ab.abnt_adress, ' ', dr.request_id) LIKE '%" + searchData + "%' " +
                            "ORDER BY dr.request_date DESC";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

    }
}
