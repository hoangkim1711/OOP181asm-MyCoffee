using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffee.DAO {
    public class BillDetailDAO {
        private static BillDetailDAO instance;

        public static BillDetailDAO Instance {
            get { if (instance == null) instance = new BillDetailDAO(); return BillDetailDAO.instance; }
            private set { BillDetailDAO.instance = value; }
        }

        private BillDetailDAO() { }

        public void InsertBillDetail(int idBillDetail, int idBill, string idItem, string itemName, int quantity, string totalPrice) {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillDetail @idBillDetail , @idBill , @idItem , @itemName , @quantity , @totalPrice", new object[] { idBillDetail, idBill, idItem, itemName, quantity, totalPrice });
        }
        public int GetMaxIDBillDetail()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(BillDetailID) FROM dbo.BillDetail");
            }
            catch
            {
                return 0;
            }
        }
    }
}