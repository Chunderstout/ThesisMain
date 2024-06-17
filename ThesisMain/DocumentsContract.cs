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
    internal class DocumentsContract
    {
        DBconnect connect = new DBconnect();

        public DataTable GetDocumentContract()
        {
            string query = "SELECT c.contract_id, c.account_id, c.contract_date, a.abnt_firstname, a.abnt_middlename, a.abnt_lastname, a.abnt_adress FROM documentcontract c INNER JOIN abonent a ON c.account_id = a.account_id;";
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool Insertcontract(int accountId, DateTime contractDate)
        {

            connect.openConnect();

            string checkContractQuery = "SELECT COUNT(*) FROM documentcontract WHERE account_id = @accId";
            MySqlCommand checkContractCommand = new MySqlCommand(checkContractQuery, connect.GetConnection);
            checkContractCommand.Parameters.AddWithValue("@accId", accountId);
            int contractCount = Convert.ToInt32(checkContractCommand.ExecuteScalar());

            if (contractCount > 0)
            {
                MessageBox.Show("Договор для данного пользователя уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string insertActQuery = "INSERT INTO documentcontract (account_id, contract_date) VALUES (@accId, @date)";
            MySqlCommand insertActCommand = new MySqlCommand(insertActQuery, connect.GetConnection);
            insertActCommand.Parameters.AddWithValue("@accId", accountId);
            insertActCommand.Parameters.AddWithValue("@date", contractDate);

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

        public DataTable searchcontract(string searchdata)
        {
            string query = "SELECT dc.contract_id, dc.account_id, dc.contract_date, a.account_number, ab.abnt_firstname, ab.abnt_middlename, ab.abnt_lastname " +
                            "FROM documentcontract dc " +
                            "JOIN account a ON dc.account_id = a.account_id " +
                            "JOIN abonent ab ON a.account_id = ab.account_id " +
                            "WHERE CONCAT(ab.abnt_firstname, ' ', ab.abnt_middlename, ' ', ab.abnt_lastname, ' ', ab.abnt_adress) LIKE '%" + searchdata + "%'";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }




    }
}
