using MySql.Data.MySqlClient;
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

        GunplaRepository db = new GunplaRepository();

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string error = db.Connect();

            if (error != null)
                MessageBox.Show(error);
            //else
            //    MessageBox.Show("MySQL 접속 성공");

            DataSet data = db.Mechanic();
            gridMechanic.DataSource = data;
            gridMechanic.DataMember = "mechanic";
        }

        private void OnAdd(object sender, EventArgs e) {
            if (textName.Text.ToString().Length == 0) {
                MessageBox.Show("Name을 입력해 주세요.");
                textName.Focus();
                return;
            }

            if (textModel.Text.ToString().Length == 0) {
                MessageBox.Show("Model을 입력해 주세요.");
                textModel.Focus();
                return;
            }

            if (textHeight.Text.ToString().Length == 0) {
                MessageBox.Show("Height를 입력해 주세요.");
                textHeight.Focus();
                return;
            }

            double height = 0.0f;
            if (double.TryParse(textHeight.Text, out height) == false) {
                MessageBox.Show("Height를 double 타입으로 입력해 주세요.");
                textHeight.Focus();
                return;
            }

            if (textWeight.Text.ToString().Length == 0) {
                MessageBox.Show("Weight를 입력해 주세요.");
                textWeight.Focus();
                return;
            }

            double weight = 0.0f;
            if (double.TryParse(textWeight.Text, out weight) == false) {
                MessageBox.Show("Weight를 double 타입으로 입력해 주세요.");
                textWeight.Focus();
                return;
            }

            db.Insert(
                textName.Text, 
                textModel.Text,
                textManufacturer.Text,
                textArmor.Text,
                height,
                weight
            );

            gridMechanic.DataSource = db.Mechanic();
        }
    }
}
