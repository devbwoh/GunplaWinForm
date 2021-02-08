using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunplaWinForm {
     class GunplaRepository {
        MySqlConnection dbc = null;

        public string Connect() {
            if (dbc != null)
                dbc.Close();

            string con = "server=13.209.64.228;user=root;database=gunpladb;port=50513;password=mysql1234;charset='utf8'";
            dbc = new MySqlConnection(con);
            try {
                dbc.Open();
            }
            catch (Exception ex) {
                return ex.ToString();
            }
            return null;
        }
        public void Close() {
            dbc.Close();
        }

        public DataSet Mechanic() {
            if (dbc.State != ConnectionState.Open)
                return null;

            string query = "SELECT * FROM mechanic";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbc);

            DataSet data = new DataSet();
            adapter.Fill(data, "mechanic");

            return data;
        }

        public string Insert(string name, string model, string manufacturer, string armor, double height, double weight) {
            try {
                string query = @"
                    INSERT INTO mechanic (id, name, model, manufacturer, armor, height, weight) VALUES
                    (null, @name, @model, @manufacturer, @armor, @height, @weight)
                ";
                MySqlCommand cmd = new MySqlCommand(query, dbc);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@manufacturer", manufacturer);
                cmd.Parameters.AddWithValue("@armor", armor);
                cmd.Parameters.AddWithValue("@height", height);
                cmd.Parameters.AddWithValue("@weight", weight);
                cmd.ExecuteNonQuery();
                return null;
            }
            catch (Exception ex) {
                return ex.ToString();
            }
        }
    }
}
