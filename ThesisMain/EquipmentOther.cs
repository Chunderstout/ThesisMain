using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisMain
{
    internal class EquipmentOther
    {
        DBconnect connect = new DBconnect();
        public DataTable GetEquipmentOther()
        {
            string query = "SELECT e.eqother_id, e.account_id, e.eqother_model, e.eqother_type, e.eqother_date, a.abnt_firstname, a.abnt_middlename, a.abnt_lastname, a.abnt_adress FROM equipmentother e INNER JOIN abonent a ON e.account_id = a.account_id;";
            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool InsertEquipmentOther(int accountId, string eqoModel, string eqoType, DateTime eqoDate)
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

            string insertActQuery = "INSERT INTO equipmentother (account_id, eqother_model, eqother_type, eqother_date) VALUES (@accId, @eqoModel, @eqotype, @eqodate)";
            MySqlCommand insertActCommand = new MySqlCommand(insertActQuery, connect.GetConnection);
            insertActCommand.Parameters.AddWithValue("@accId", accountId);
            insertActCommand.Parameters.AddWithValue("@eqoModel", eqoModel);
            insertActCommand.Parameters.AddWithValue("@eqotype", eqoType);
            insertActCommand.Parameters.AddWithValue("@eqodate", eqoDate);

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

        public DataTable searchEquipmentOther(string searchdata)
        {
            string query = "SELECT eo.eqother_id, eo.eqother_model, eo.account_id, eo.eqother_type, eo.eqother_date, a.account_number, ab.abnt_firstname, ab.abnt_middlename, ab.abnt_lastname, ab.abnt_adress " +
                            "FROM equipmentother eo " +
                            "JOIN account a ON eo.account_id = a.account_id " +
                            "JOIN abonent ab ON a.account_id = ab.account_id " +
                            "WHERE CONCAT(ab.abnt_firstname, ' ', ab.abnt_middlename, ' ', ab.abnt_lastname, ' ', ab.abnt_adress, ' ', CAST(eo.eqother_id AS CHAR)) LIKE '%" + searchdata + "%'";

            MySqlCommand command = new MySqlCommand(query, connect.GetConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
