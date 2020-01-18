using MyCoffee.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCoffee {
    public partial class FormAccountInfo : Form {
        public FormAccountInfo() {
            InitializeComponent();
            LoadAccountInfoByID();

        }
        void LoadAccountInfoByID() {
            string query = "SELECT AccountName FROM dbo.AccountInfo WHERE AccountID = " + FormLogin.staticAccountID.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows) {
                txtName.Text = item[0].ToString();
            }

            string query2 = "SELECT AccountSex FROM dbo.AccountInfo WHERE AccountID = " + FormLogin.staticAccountID.ToString();
            DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);
            foreach (DataRow item in data2.Rows) {
                txtSex.Text = item[0].ToString();
            }

            string query3 = "SELECT AccountAddress FROM dbo.AccountInfo WHERE AccountID = " + FormLogin.staticAccountID.ToString();
            DataTable data3 = DataProvider.Instance.ExecuteQuery(query3);
            foreach (DataRow item in data3.Rows) {
                txtAddress.Text = item[0].ToString();
            }

            string query4 = "SELECT AccountPhone FROM dbo.AccountInfo WHERE AccountID = " + FormLogin.staticAccountID.ToString();
            DataTable data4 = DataProvider.Instance.ExecuteQuery(query4);
            foreach (DataRow item in data4.Rows)
            {
                txtPhone.Text = item[0].ToString();
            }

        }


        private void btnThoat_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FormAccountInfo_Load(object sender, EventArgs e) {

        }
    }
}
