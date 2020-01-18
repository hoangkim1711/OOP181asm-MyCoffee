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
    public partial class FormLogin : Form {
        public static int staticAccountID = -1; //tạo AccountID để xử lý nhập bill
        public FormLogin() {
            InitializeComponent();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Do you really want to exit?", "Notice", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK) {
                e.Cancel = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (Login(username, password)) {
                FormStaff f = new FormStaff();
                this.Hide();
                f.ShowDialog();
                this.Show();
            } else {
                MessageBox.Show("The username or password you entered is incorrect!");
            }
        }

        bool Login(string account, string password) {
            return AccountDAO.Instance.Login(account, password);
        }
   
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, new EventArgs() );
            }
        }
    }
}
