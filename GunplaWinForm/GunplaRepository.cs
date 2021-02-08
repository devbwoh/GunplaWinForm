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
            string con = "server=52.79.110.60;user=root;database=gunpladb;port=52804;password=mysql1234";
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
            MySqlDataAdapter adapter;
            string query = "SELECT * FROM mechanic";
            adapter = new MySqlDataAdapter(query, dbc);

            DataSet data = new DataSet();
            adapter.Fill(data, "mechanic");

            return data;
        }
    }
}
