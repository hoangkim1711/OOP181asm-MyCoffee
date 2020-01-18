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
    public partial class FormHistoryBill : Form {
        public FormHistoryBill() {
            InitializeComponent();
            LoadBill();
        }

        void LoadBill() {
            string query = "SELECT * FROM dbo.Bill";
            dtgViewBill.DataSource = DataProvider.Instance.ExecuteQuery(query);
            string query2 = "SELECT * FROM dbo.BillDetail";
            dtgViewBillDetail.DataSource = DataProvider.Instance.ExecuteQuery(query2);
        }
    }
}
