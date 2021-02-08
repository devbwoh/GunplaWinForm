using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunplaWinForm {
    class GunplaRepository {
        MySqlConnection dbc = null;
        MySqlDataReader res = null;

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

        public void SelectMechanic() {
            string query = "SELECT * FROM mechanic";
            MySqlCommand cmd = new MySqlCommand(query, dbc);
            res = cmd.ExecuteReader();

            while (res.Read()) {
                Console.WriteLine(res[0] + " -- " + res[1]);
            }
            res.Close();
        }
    }

}
