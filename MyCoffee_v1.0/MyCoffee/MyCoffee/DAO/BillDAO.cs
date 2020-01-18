using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffee.DAO {
    public class BillDAO {
        private static BillDAO instance;

        public static BillDAO Instance {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public void InsertBill(int idBill, int idStaf, string totalBill) {
            string staftName = "null";
            //lấy NameStaff từ AccountID
            string query = "SELECT AccountName FROM dbo.AccountInfo WHERE AccountID =" + FormLogin.staticAccountID;
            DataTable nameStaff = DataProvider.Instance.ExecuteQuery(query);          
            foreach (DataRow item in nameStaff.Rows)
            {
                staftName = item[0].ToString();
            }
            //thêm bill mới vào Database
            DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_InsertBill @idBill , @idStaff , @staffName , @priceBill ", new object[] { idBill, idStaf, staftName, totalBill });        
        }

        public int GetMaxIDBill() {
            try {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(BillID) FROM dbo.Bill");
            } catch {
                return 0;
            }
        }
    }
}