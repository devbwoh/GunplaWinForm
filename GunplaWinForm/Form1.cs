using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunplaWinForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            GunplaRepository db = new GunplaRepository();

            string error = db.Connect();

            if (error != null)
                MessageBox.Show(error);
            //else
            //    MessageBox.Show("MySQL 접속 성공");

            db.SelectMechanic();
        }
    }
}
