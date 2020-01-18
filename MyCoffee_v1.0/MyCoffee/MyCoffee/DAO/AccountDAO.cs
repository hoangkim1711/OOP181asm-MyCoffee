using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyCoffee.DAO {
    public class AccountDAO {
        private static AccountDAO instance;

        public static AccountDAO Instance {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord) {
            string query = "SELECT * FROM dbo.Account WHERE userName = N'" + userName + "' AND passWord = N'" + passWord + "' AND type = N'0'"; //only Staff, not Admin        
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            //lấy AccountID
            foreach (DataRow item in result.Rows) {
                FormLogin.staticAccountID = Convert.ToInt32(item[0].ToString());
            }
            return result.Rows.Count > 0;
        }
    }
}
